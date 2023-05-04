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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dane_wyjsciowe.Text = dane_wejsciowe.Text;
            dane_wyjsciowe.Background = Brushes.Red;


        }

        private void dane_wejsciowe_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           e.Cancel =  MessageBox.Show("Czy na pewno chcesz zamknąć okno?", "Zamykanie okna", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NoweOkno okno = new NoweOkno();
            //okno.ShowDialog();
            okno.Show();


        }
    }
}
