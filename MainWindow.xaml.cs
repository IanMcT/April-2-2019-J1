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

namespace J12001
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

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            //input
            int H = 0;
            int.TryParse(txtInput.Text, out H);

            //debug:
            //MessageBox.Show(H.ToString());

            //process
            //create loop to output a row based on the input
            /*i.e. 5 would output:
             * 
             * 
             * 
             * 
             * 
             */
            string output = "";
            for (int i = 0; i < H; i++)
            {
                //first part
                output += "*";//fix this
                //spaces
                int s = (int)Math.Abs(2 * H - 2 * (2 * i + 1));
                for (int j = 0; j < s; j++)
                {
                    output += " ";
                }
                //last part
                output += "*" + Environment.NewLine;//fix
            }
            //debug:
            MessageBox.Show(output);
        }
    }
}
