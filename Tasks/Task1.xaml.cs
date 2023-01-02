﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        public Task1()
        {
            InitializeComponent();
        }
        private void StartProc_Click(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "calc.exe";
            process.Start();
            StartProc.Content = "Process has started!";
            process.WaitForExit();
            StartProc.Content = $"Process ended with code: {process.ExitCode}";
        }
    }
}
