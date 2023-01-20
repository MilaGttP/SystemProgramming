using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using AssemblyLoadLibrary;

namespace SystemProgramming
{
    public partial class MainWindow : Window
    {
        Assembly assembly;
        public MainWindow()
        {
            InitializeComponent();
            assembly = Assembly.LoadFrom("AssemblyLoadLibrary.dll");
        }
        private void Task1_Click(object sender, RoutedEventArgs e)
        {
            Type? t = assembly.GetType("AssemblyLoadLibrary.Message");
            if (t != null)
            {
                MethodInfo? info = t.GetMethod("Message", BindingFlags.Static);
                var result = info?.Invoke(null, new object[] { });
                MessageBox.Show(result.ToString());
            }
        }

        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            Type? t = assembly.GetType("AssemblyLoadLibrary.CheckIntercalaryYear");
            if (t != null)
            {
                MethodInfo? info = t.GetMethod("CheckYear", BindingFlags.Static);
                var result = info?.Invoke(null, new object[] { 2006 });
                MessageBox.Show(result.ToString());
            }
        }

        private void Task3_Click(object sender, RoutedEventArgs e)
        {
            Type? t = assembly.GetType("AssemblyLoadLibrary.MaxMinSum");
            if (t != null)
            {
                MethodInfo? info = t.GetMethod("Sum", BindingFlags.Static);
                var result = info?.Invoke(null, new object[] { 2, 5, 8 });
                MessageBox.Show(result.ToString());
            }
        }

        private void Task4_Click(object sender, RoutedEventArgs e)
        {
            Type? t = assembly.GetType("AssemblyLoadLibrary.FactorialSimple");
            if (t != null)
            {
                MethodInfo? info = t.GetMethod("Factorial", BindingFlags.Static);
                var result = info?.Invoke(null, new object[] { 5 });
                MessageBox.Show(result.ToString());
            }
        }

        private void Task5_Click(object sender, RoutedEventArgs e)
        {
            Type? t = assembly.GetType("AssemblyLoadLibrary.Fraction");
            if (t != null)
            {
                MethodInfo? info = t.GetMethod("", BindingFlags.Static);
                var result = info?.Invoke(null, new object[] { 5 });
                MessageBox.Show(result.ToString());
            }
        }
    }
}
