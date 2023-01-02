
using System.Windows;

namespace SystemProgramming
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Task1_Click(object sender, RoutedEventArgs e)
        {
            Task1 task1 = new Task1();
            task1.ShowDialog();
        }

        private void Task2And3_Click(object sender, RoutedEventArgs e)
        {
            Task2And3 task2And3 = new Task2And3();
            task2And3.ShowDialog();
        }

        private void Task4And5_Click(object sender, RoutedEventArgs e)
        {
            Task4And5 task4And5 = new Task4And5();
            task4And5.ShowDialog();
        }
    }
}
