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
using System.Threading;

namespace SystemProgramming
{
    public partial class Task1 : UserControl
    {
        public Task1()
        {
            InitializeComponent();
        }
        void GenerateNumbers(object obj)
        {
            List<int> numbers = new List<int>();
            Semaphore semaphore = obj as Semaphore;
            uint i = 20;
            Random r = new Random();
            while (i != 0)
            {
                numbers.Add(r.Next(10));
                --i;
            }
            foreach (var item in numbers) MessageBox.Show(item.ToString());
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            Semaphore semaphore = new Semaphore(3, 3);
            for (int i = 0; i < 10; ++i)
            {
                ThreadPool.QueueUserWorkItem(GenerateNumbers, semaphore);
            }
        }
    }
}
