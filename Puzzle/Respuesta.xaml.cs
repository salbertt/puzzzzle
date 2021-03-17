using System;
using System.Threading;
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

namespace Puzzle {
    /// <summary>
    /// Lógica de interacción para Respuesta.xaml
    /// </summary>
    public partial class Respuesta : Window {

        public Respuesta() {


            InitializeComponent();

           

        }

        private async void Window_InitializedAsync(object sender, EventArgs e) {
            SolidColorBrush azulOg = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFAAF7FF"));
            SolidColorBrush moradoOg = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD9C8FF"));
            SolidColorBrush azulN = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF38EAFD"));
            SolidColorBrush moradoN = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFAA86F9"));


            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"d:\\Users\\sofal\\Downloads\\Puzzle3x3-master\\Puzzle3x3-master\\data.txt");
            while ((line = file.ReadLine()) != null) {

                int pFrom = line.IndexOf("(") + "(".Length;
                int pTo = line.LastIndexOf(")");

                String result = line.Substring(pFrom, pTo - pFrom);


                
                

                string[] words = result.Split(' ');
                if (!tb1.Text.Equals(words[0])) {
                    tb1.Background = azulN;
                }
                if (!tb2.Text.Equals(words[1])) {
                    tb2.Background = moradoN;
                }
                if (!tb3.Text.Equals(words[2])) {
                    tb3.Background = azulN;
                }
                if (!tb4.Text.Equals(words[3])) {
                    tb4.Background = moradoN;
                }
                if (!tb5.Text.Equals(words[4])) {
                    tb5.Background = azulN;
                }
                if (!tb6.Text.Equals(words[5])) {
                    tb6.Background = moradoN;
                }
                if (!tb7.Text.Equals(words[6])) {
                    tb7.Background = azulN;
                }
                if (!tb8.Text.Equals(words[7])) {
                    tb8.Background = moradoN;
                }
                if (!tb9.Text.Equals(words[8])) {
                    tb9.Background = azulN;
                }


                tb1.Text = words[0];
                tb2.Text = words[1];
                tb3.Text = words[2];
                tb4.Text = words[3];
                tb5.Text = words[4];
                tb6.Text = words[5];
                tb7.Text = words[6];
                tb8.Text = words[7];
                tb9.Text = words[8];

                Console.WriteLine(result);
              

                counter++;
                await Task.Delay(3000);
                tb1.Background = azulOg;
                tb2.Background = moradoOg;
                tb3.Background = azulOg;
                tb4.Background = moradoOg;
                tb5.Background = azulOg;
                tb6.Background = moradoOg;
                tb7.Background = azulOg;
                tb8.Background = moradoOg;
                tb9.Background = azulOg;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
            proceso.Content = "";
            MessageBox.Show("¡Listo! Puzzle resuelto");


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow ventana = new MainWindow();
            ventana.Show();

            this.Close();
        }
    }
}
