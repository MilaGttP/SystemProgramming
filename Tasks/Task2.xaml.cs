using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Wait_Click(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "calc.exe";
            process.Start();
            MessageBox.Show("Process has started!");
            process.WaitForExit();
            MessageBox.Show($"Process ended with code: {process.ExitCode}");
        }

        private void Kill_Click(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "calc.exe";
            process.Start();
            MessageBox.Show("Process has started!");
            Thread.Sleep(1000);
            process.Kill();
        }
    }
}
