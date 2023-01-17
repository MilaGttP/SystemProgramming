using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Threading;

namespace SystemProgramming
{ 
    public partial class Task2 : UserControl
    {
        Mutex mutex;
        public Task2()
        {
            InitializeComponent();
            mutex = new Mutex();
        }

        void Print()
        {
            mutex.WaitOne();
            List<int> twenty = new List<int>();
            for (int i = 0; i < 21; i++) twenty.Add(i);
            foreach (int item in twenty) MessageBox.Show(item.ToString(), "Thread one");

            List<int> ten = new List<int>();
            for (int i = 0; i < 11; i++) ten.Add(i);
            foreach (int item in ten.Reverse<int>()) MessageBox.Show(item.ToString(), "Thread two");
            mutex.ReleaseMutex();
        }
        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(Print));
                thread.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
