using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Puzzle {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
      
    public partial class MainWindow : Window {
        private string a1,a2, a3, a4, a5, a6, a7, a8, a9,b1,b2,b3,b4,b5,b6,b7,b8,b9;

        private void bt1_Click(object sender, RoutedEventArgs e) {
            String ini, fin, pos = "0";

            a1 = tb1.Text.ToString();
            a2 = tb2.Text.ToString();
            a3 = tb3.Text.ToString();
            a4 = tb4.Text.ToString();
            a5 = tb5.Text.ToString();
            a6 = tb6.Text.ToString();
            a7 = tb7.Text.ToString();
            a8 = tb8.Text.ToString();
            a9 = tb9.Text.ToString();

            b1 = tb12.Text.ToString();
            b2 = tb22.Text.ToString();
            b3 = tb32.Text.ToString();
            b4 = tb42.Text.ToString();
            b5 = tb52.Text.ToString();
            b6 = tb62.Text.ToString();
            b7 = tb72.Text.ToString();
            b8 = tb82.Text.ToString();
            b9 = tb92.Text.ToString();

            if (a1.Equals("0"))
                pos = "0";
            else if (a2.Equals("0"))
                pos = "1";
            else if (a3.Equals("0"))
                pos = "2";
            else if (a4.Equals("0"))
                pos = "3";
            else if (a5.Equals("0"))
                pos = "4";
            else if (a6.Equals("0"))
                pos = "5";
            else if (a7.Equals("0"))
                pos = "6";
            else if (a8.Equals("0"))
                pos = "7";
            else if (a9.Equals("0"))
                pos = "8";


            ini = a1 + " " + a2 + " " + a3 + " " + a4 + " " + a5 + " " + a6 + " " + a7 + " " +
                a8 + " " + a9 + " " + pos;

            if (b1.Equals("0"))
                pos = "0";
            else if (b2.Equals("0"))
                pos = "1";
            else if (b3.Equals("0"))
                pos = "2";
            else if (b4.Equals("0"))
                pos = "3";
            else if (b5.Equals("0"))
                pos = "4";
            else if (b6.Equals("0"))
                pos = "5";
            else if (b7.Equals("0"))
                pos = "6";
            else if (b8.Equals("0"))
                pos = "7";
            else if (b9.Equals("0"))
                pos = "8";

            fin = b1 + " " + b2 + " " + b3 + " " + b4 + " " + b5 + " " + b6 + " " + b7 + " " +
                b8 + " " + b9 + " " + pos;

            File.WriteAllText("d:\\Users\\sofal\\Downloads\\Puzzle3x3-master\\Puzzle3x3-master\\estadoInicial.txt", ini);
            File.WriteAllText("d:\\Users\\sofal\\Downloads\\Puzzle3x3-master\\Puzzle3x3-master\\estadoFinal.txt", fin);


            //string strCmdText;
            //strCmdText = "(/C sbcl --script C:\\Users\\Edgar\\Desktop\\Puzzle\\solucionPuzzle.lisp )";
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "(/C sbcl --script d:\\Users\\sofal\\Downloads\\Puzzle3x3-master\\Puzzle3x3-master\\solucionPuzzle.lisp )";
            process.StartInfo = startInfo;
            process.Start();

            Respuesta window1 = new Respuesta();
            window1.Show();

            this.Close();

        }

        public MainWindow() {
            InitializeComponent();
           
        }

        


    }
}
