
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

        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            Task2 task2 = new Task2();
            task2.ShowDialog();
        }

        private void Task3_Click(object sender, RoutedEventArgs e)
        {
            Task3 task3 = new Task3();
            task3.ShowDialog();
        }

        private void Task4_Click(object sender, RoutedEventArgs e)
        {
            Task4 task4 = new Task4();
            task4.ShowDialog();
        }
    }
}
