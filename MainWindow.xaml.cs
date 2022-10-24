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
namespace hw3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char[] alp = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string num1 = textbox1.Text;
            string[] separators = num1.Split(new char[] { ' ', ',', '.' });
            int[] num = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < separators.Length; ++i)
            {
                separators[i] = separators[i].ToLower();
                for (int j = 0; j < separators[i].Length; ++j)
                {
                    for (int k = 0; k < 26; ++k)
                    {
                        if (separators[i][j] == alp[k])
                        {
                            num[k]++;
                        }
                    }
                }
            }
            for (int i = 0; i < 26; ++i)
            {
                if (num[i] != 0)
                {
                    textbox2.AppendText(alp[i] + "的個數:" + num[i]);
                }
                textbox2.AppendText("\r\n");
            }
        }
    }
}