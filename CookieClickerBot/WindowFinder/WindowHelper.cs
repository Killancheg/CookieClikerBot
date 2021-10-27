using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using CookieClickerBot.ProcessTypes;

namespace CookieClickerBot.WindowFinder
{
    static class WindowHelper
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder strText, int maxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        // Delegate to filter which windows to include 
        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        /// <summary> Get the text for the window pointed to by hWnd </summary>
        public static string GetWindowText(IntPtr hWnd)
        {
            int size = GetWindowTextLength(hWnd);
            if (size > 0)
            {
                var builder = new StringBuilder(size + 1);
                GetWindowText(hWnd, builder, builder.Capacity);
                return builder.ToString();
            }

            return String.Empty;
        }

        /// <summary> Find all windows that match the given filter </summary>
        /// <param name="filter"> A delegate that returns true for windows
        ///    that should be returned and false for windows that should
        ///    not be returned </param>
        public static IEnumerable<IntPtr> FindWindows(EnumWindowsProc filter)
        {
            IntPtr found = IntPtr.Zero;
            List<IntPtr> windows = new List<IntPtr>();

            EnumWindows(delegate (IntPtr wnd, IntPtr param)
            {
                if (filter(wnd, param))
                {
                    // only add the windows that pass the filter
                    windows.Add(wnd);
                }

                // but return true here so that we iterate all windows
                return true;
            }, IntPtr.Zero);

            return windows;
        }

        /// <summary> Find all windows that contain the given title text </summary>
        /// <param name="titleText"> The text that the window title must contain. </param>
        public static IEnumerable<IntPtr> FindWindowsWithText(string titleText)
        {
            return FindWindows(delegate (IntPtr wnd, IntPtr param)
            {
                return GetWindowText(wnd).Contains(titleText);
            });
        }


        delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);

        private static List<Process> GetProcessesWithWindowsList()
        {
            List<Process> processesWithWindows = new List<Process>();

            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                if (process.MainWindowTitle.Length > 0)
                    processesWithWindows.Add(process);
            }

            return processesWithWindows;
        }

        public static List<ComboBoxWindows> GetComboBoxOpenedWindowsList()
        {
            List<ComboBoxWindows> comboBoxOpenedWindowsList = new List<ComboBoxWindows>();

            List<Process> processesWithWindows = GetProcessesWithWindowsList();

            foreach (var process in processesWithWindows)
            {
                IEnumerable<IntPtr> windowsInProcess = EnumerateProcessWindowHandles(process.Id);
                bool areMultipleWindows = windowsInProcess.Count() > 1;

                int numeration = 1;

                foreach (var window in windowsInProcess)
                {
                    comboBoxOpenedWindowsList.Add(new ComboBoxWindows(process.MainWindowTitle, window, numeration));

                    numeration++;
                }
            }
            comboBoxOpenedWindowsList = comboBoxOpenedWindowsList.OrderBy(x => x.Name).ThenBy(x => x.Numeration).ToList();


            return comboBoxOpenedWindowsList;
        }

        [DllImport("user32.dll")]
        static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn, IntPtr lParam);

        public static IEnumerable<IntPtr> EnumerateProcessWindowHandles(int processId)
        {
            var handles = new List<IntPtr>();

            foreach (ProcessThread thread in Process.GetProcessById(processId).Threads)
                EnumThreadWindows(thread.Id,
                    (hWnd, lParam) => { handles.Add(hWnd); return true; }, IntPtr.Zero);

            return handles;
        }
    }
}
