using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Threading;
using System.Linq;

namespace SystemProgramming
{
    public partial class MainWindow : Window
    {
        Info info;
        string text;
        public MainWindow()
        {
            InitializeComponent();
            info = new Info();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            if (text != null)
            {
                Task sentQuan = Task.Factory.StartNew(() =>
                {
                    info.SentQuan = TB.Text.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries).Length;
                });
            }
            else MessageBox.Show("Enter text!", "Error!");
        }

        private void TB_TextChanged(object sender, TextChangedEventArgs e)
        {
            text = TB.Text.ToString();
        }
    }
}
