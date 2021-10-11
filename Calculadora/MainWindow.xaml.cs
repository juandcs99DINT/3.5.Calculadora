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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void botonNumeroClick(object sender, RoutedEventArgs e)
        {
            
            Button botonNumero = (Button)sender;
            switch(botonNumero.Tag)
            {
                case "1":
                    NumerosTextBlock.Text += 1;
                    break;
                case "2":
                    NumerosTextBlock.Text += 2;
                    break;
                case "3":
                    NumerosTextBlock.Text += 3;
                    break;
                case "4":
                    NumerosTextBlock.Text += 4;
                    break;
                case "5":
                    NumerosTextBlock.Text += 5;
                    break;
                case "6":
                    NumerosTextBlock.Text += 6;
                    break;
                case "7":
                    NumerosTextBlock.Text += 7;
                    break;
                case "8":
                    NumerosTextBlock.Text += 8;
                    break;
                case "9":
                    NumerosTextBlock.Text += 9;
                    break;
                case "0":
                    NumerosTextBlock.Text += 0;
                    break;
            }
        }
    }
}
