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
    public partial class Task2 : Window
    {
        int[] source;
        public Task2()
        {
            InitializeComponent();
            source = new int[] { 1, 3, 2, 5, 8, 9, 13, 2};
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            List<int> seq = new List<int>();
            for (int i = 0; i < source.Length; i++) 
            { 
                if (source[i + i] > source[i]) seq.Add(source[i + i]);
            }
            SequenceTB.Text = seq.ToString();
            CountTB.Text = seq.Count().ToString();
        }
    }
}
