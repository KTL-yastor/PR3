using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFduzo
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

        void Praca() {
            Thread.Sleep(3000);
        }

        private void bnt_nowe_okno_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;
            //button.Background = Brushes.Red;
            button.FontFamily = new FontFamily("Comic Sans MS");
            //button.FontSize = 20;
            button.IsEnabled = false;
            button.Content = "Zablokowany";
            //odpalenie nowego okna Window1
            Window1 okno = new Window1();
            okno.Show();
          
        }

        private void bnt_testowo(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = Brushes.White;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //message box z pytaniem o zamknięcie
            MessageBoxResult key = MessageBox.Show("Czy na pewno chcesz zamknąć okno?", "Zamykanie okna", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes);
            if (key == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bnt_test_Click(object sender, RoutedEventArgs e)
        {
            //kolor tła na czerwony
            
            this.Resources["Test"] = new SolidColorBrush(Colors.Red);
            
            
        }

        private void Menu_open(object sender, RoutedEventArgs e)
        {
            Window1 okno = new Window1();
            okno.Show();
        }

        private void czysci_okno(object sender, RoutedEventArgs e)
        {
            tekstbox.Text = "";
        }

        Task pracatask() {
           return Task.Run(Praca);
        }

        async private void Drukuje_napis(object sender, RoutedEventArgs e)
        {
            MessageBoxResult key = MessageBox.Show("Czy wydrukowac?", "Drukarka", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.Yes);

            if (key == MessageBoxResult.Yes)
            {
                //drukuje

                poleDruk.Content = "Drukuje...";
                tekstbox.IsEnabled = false;
                await pracatask();
                tekstbox.IsEnabled = true;
                poleDruk.Content = tekstbox.Text;
            }
            else {
                MessageBox.Show("Nie wydrukowano");
            }
            
        }

        private void Drukuje_napis_thread(object sender, RoutedEventArgs e)
        {
            //drukuje
            Thread watek = new Thread(() =>
            {
                Dispatcher.BeginInvoke(new Action(() => { poleDruk.Content = "Drukuje..."; tekstbox.IsEnabled = false; }));
                
                Praca();
                
                Dispatcher.BeginInvoke(new ThreadStart(() => { tekstbox.IsEnabled = true;  poleDruk.Content = tekstbox.Text; }));
                
            });
            watek.Start();
        }
    } 
}
