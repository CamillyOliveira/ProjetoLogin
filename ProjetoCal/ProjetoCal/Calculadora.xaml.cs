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

namespace ProjetoCal
{
    /// <summary>
    /// Lógica interna para Calculadora.xaml
    /// </summary>
    public partial class Calculadora : Window
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void BotaoMenos_Click(object sender, RoutedEventArgs e)
        {
            float primeiroNumero = Convert.ToInt32(priNumero.Text);
            float segundoNumero = Convert.ToInt32(segNumero.Text);
            float resultado = primeiroNumero - segundoNumero;
            TextResultado.Text = Convert.ToString(resultado);
        }

        private void BotaoDividir_Click(object sender, RoutedEventArgs e)
        {
            float primeiroNumero = Convert.ToInt32(priNumero.Text);
            float segundoNumero = Convert.ToInt32(segNumero.Text);
            float resultado = primeiroNumero / segundoNumero;
            TextResultado.Text = Convert.ToString(resultado);
        }

        private void BotaoSomar_Click(object sender, RoutedEventArgs e)
        {
            float primeiroNumero = Convert.ToInt32(priNumero.Text);
            float segundoNumero = Convert.ToInt32(segNumero.Text);
            float resultado = primeiroNumero + segundoNumero;
            TextResultado.Text = Convert.ToString(resultado);
        }

        private void BotaoVezes_Click(object sender, RoutedEventArgs e)
        {
            float primeiroNumero = Convert.ToInt32(priNumero.Text);
            float segundoNumero = Convert.ToInt32(segNumero.Text);
            float resultado = primeiroNumero * segundoNumero;
            TextResultado.Text = Convert.ToString(resultado);
        }
    }
}
