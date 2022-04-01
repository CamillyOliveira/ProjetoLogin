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

namespace ProjetoCal
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotaoLogar_Click(object sender, RoutedEventArgs e)
        {
            string senha = PassSenha.Password.ToString();
            string usuario = TextUsuario.Text;

            if(usuario == "camillysouza" & senha == "12101996")
            {
                MessageBox.Show("LOGIN EFETUADO!!!");
                TextUsuario.Clear();
                PassSenha.Clear();
                Calculadora calculadora = new Calculadora();
                calculadora.Show();
            }

            else
            {
                MessageBox.Show("Usuário ou senha Inválido!!!");
                TextUsuario.Clear();
                PassSenha.Clear();
            }
        }
    }
}
