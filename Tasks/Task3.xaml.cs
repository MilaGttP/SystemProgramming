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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SystemProgramming
{
    [DllImport("kernel32.dll", SetLastError=true)]
    private static extern bool Beep(uint dwFreq, uint dwDuration);


    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool MessageBeep(uint uType);

    public partial class Task3 : Window
    {
        public Task3()
        {
            InitializeComponent();
        }
    }
}
