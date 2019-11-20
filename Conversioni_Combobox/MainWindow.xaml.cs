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

namespace Conversioni_Combobox
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

        private void Convert_Click(object sender, RoutedEventArgs e)
        {

            if (SceltaConversione.SelectedIndex == 0)
            {
                int numero = int.Parse(NumeroDaConvertire.Text);
                string r = string.Empty;
                //r = Convert.ToString(numero, 2);
                int resto;
                while (numero > 0)
                {
                    resto = numero % 2;
                    numero /= 2;
                    r = resto.ToString() + r;
                }




            }
            else
            {
                try
                {
                    string numero = NumeroDaConvertire.Text;
                    int r = 0;
                    int exp = 0;
                    for (int i = numero.Length - 1; i >= 0; i--)
                    {
                        if (numero[i] == '1')
                        {

                            r += (int)Math.Pow(2, exp);

                        }
                        else if (numero[i] != '0')
                            throw new Exception("Non è un numero binario");
                        exp++;
                    }
                    Risultato.Text = r.ToString();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}

