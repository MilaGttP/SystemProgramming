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
using System.Windows.Shapes;

namespace SystemProgramming
{
    public partial class Task1 : Window
    {
        List<int> source;
        public Task1()
        {
            InitializeComponent();
            source = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 100; i++) source.Add(random.Next(0, 50));
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            var count = (from n in source select n).AsParallel().Distinct().Count();
            ResultTB.Text = count.ToString();
        }
    }
}
