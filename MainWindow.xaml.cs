/*Ian McTavish
 * April 2, 2019
 * J1: 2001 CCC problem
 */
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

namespace j12001
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

                int numbAstericks = (H/2 - (int)Math.Abs(H / 2 - i))*2+1;

                //output the asteriks
                for (int a = 0; a < numbAstericks; a++)
                {
                    output += "*";
                }

                
                //spaces
                int s = (int)Math.Abs(2 * H - 2 * (2 * i + 1));
                int countspaces = 0;
                for (int j = 0; j < s; j++)
                {
                    output += " ";
                    countspaces++;
                }
               // MessageBox.Show(countspaces.ToString());
                //last part
                for (int a = 0; a < numbAstericks; a++)
                {
                    output += "*";
                }
                output += Environment.NewLine;//fix
            }
            //debug:
            lblOutput.Content = output;
            MessageBox.Show(output);
            Clipboard.SetText(output);//pasted into notepad to ensure the formatting was correct
            txtOutput.Text = output;
        }
    }
}
