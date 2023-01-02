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
    public partial class Task1 : Window
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
        public Task1()
        {
            InitializeComponent();
            MessageBox(new IntPtr(0), "Ivanova Mila", "Full name", 0);
            MessageBox(new IntPtr(0), "16", "Age", 0);
            MessageBox(new IntPtr(0), "Math, programming", "Favorite subjects", 0);
        }
    }        
}
