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

namespace ACESS
{
    public partial class DashboardWindow : Window
    {
        List<Colaborador> equipe = new List<Colaborador>();

        public DashboardWindow()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            equipe.Add(new ColaboradorMotor("Miguel Silva", 101, true));
            equipe.Add(new ColaboradorVisual("Ana Souza", 102, 2));
            equipe.Add(new ColaboradorMotor("Carlos Oliveira", 103, false));

            GridColaboradores.ItemsSource = equipe;
        }

        private void BtnSimular_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            foreach (var c in equipe) c.IndiceFadiga = rnd.Next(10, 95);

            
            GridColaboradores.ItemsSource = null;
            GridColaboradores.ItemsSource = equipe;
        }

        private void BtnAnalise_Click(object sender, RoutedEventArgs e)
        {
            Colaborador sel = (Colaborador)GridColaboradores.SelectedItem;
            if (sel == null) { MessageBox.Show("Selecione alguém!"); return; }

            string msg =
            $"Nome: {sel.Nome}\n" +
            $"Produtividade: {sel.CalcularProdutividade():F2}\n" +
            $"Status: {sel.StatusTexto}\n" +
            $"{sel.CalcularRecomendacaoIA()}";
    
            MessageBox.Show(msg, "Análise Completa", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }
    }
}
