using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SystemProgramming
{
    public partial class Task2 : Window
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern Int32 FindWindow(String lpClassName, String lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, int wParam, String lParam);
        public int GetWindowId(string className, string windowName)
        {
            return FindWindow (className, windowName);
        }
        public const int WM_USER = 0x400;
        public const int WM_COPYDATA = 0x4A;
       
        public Task2()
        {
            InitializeComponent();
        }

        private void CaptionTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.Title = CaptionTB.Text;
                int hWnd = GetWindowId(null, "Task2");
                SendMessage(hWnd, WM_COPYDATA, 0, $"Caption changed on {CaptionTB.Text}!");
                //MessageBox.Show($"Caption changed on {CaptionTB.Text}!");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Closed!");
        }
    }
}
