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

namespace SystemProgramming
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Task1Btn_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Task1());
        }

        private void Task2Btn_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Task2());
        }

        private void Task3Btn_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Task3());
        }

        private void Task4Btn_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Task4());
        }
    }
}
