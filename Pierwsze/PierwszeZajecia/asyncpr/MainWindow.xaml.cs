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
using System.Threading;


namespace asyncpr
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


        /*W klasie okna stwórz delegację (typ(!)) dla bezparametrowej metody nie zwracającej wartości oraz zgodne z tym typem publiczne metody:

        Pracuj() – usypiającą bieżący wątek na 3 sekundy;
        UaktualnijUI() – modyfikującą wartość kontrolki etykiety przypisującej jej stosowna informację i bieżący czas;
        PracujOrazUaktualnijUI() – wywołującą dwie powyższe metody.*/
        
        public delegate void Pracuj();
        public delegate void UaktualnijUI();
        public delegate void PracujOrazUaktualnijUI();
        public void PracujMetoda()
        {
            System.Threading.Thread.Sleep(2000);
        }
        public void UaktualnijUIMetoda()
        {
            tb_first.Text= "Praca zakonczona";
            Label_pierwszy.Content = DateTime.Now.ToString("HH:mm:ss");
        }
        public void PracujOrazUaktualnijUIMetoda()
        {
            PracujMetoda();
            UaktualnijUIMetoda();
        }


        private void bnt_first_Click(object sender, RoutedEventArgs e)
        {
            PracujOrazUaktualnijUIMetoda();

        }

        private void bnt_second_Click(object sender, RoutedEventArgs e)
        {
            ///*metoda uruchamiająca metodę PracujOrazUaktualnijUI() w nowym wątku – należy zweryfikować, 
            ///że jej próba uaktualnienia kontrolki interfejsu spowoduje błąd uruchomieniowy (Runtime Error) aplikacji;*/
            
            ThreadStart ts = new ThreadStart(PracujOrazUaktualnijUIMetoda);
            Thread t = new Thread(ts);
            t.Start();

        }

        private void bnt_third_Click(object sender, RoutedEventArgs e)
        {
            Thread watek = new Thread(() =>
            {
                PracujMetoda();
                MessageBox.Show("Test");



            });
            watek.Start();
        }

        private void bnt_four_Click(object sender, RoutedEventArgs e)
        {
            Thread watek = new Thread(() =>
            {
                //PracujMetoda();
                Dispatcher.BeginInvoke(new ThreadStart(PracujOrazUaktualnijUIMetoda));

                //Dispatcher.BeginInvoke(() => { PracujOrazUaktualnijUIMetoda(); });




            });
            watek.Start();

        }

        private void bnt_five_Click(object sender, RoutedEventArgs e)
        {
            Thread watek = new Thread(() =>
            {
                PracujMetoda();
                Dispatcher.BeginInvoke(new ThreadStart(UaktualnijUIMetoda));

            });
            watek.Start();
        }

        private async void bnt_awaitTylkoDlaOperacji_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(PracujMetoda);
            UaktualnijUIMetoda();
            //await Task.Run(PracujOrazUaktualnijUIMetoda);

        }

        string ZwrocWynik() {
            return "Praca zakonczona o:" + DateTime.Now.ToString("HH:mm:ss");
        }

        string pracujOrazZwrocWynik() {
            PracujMetoda();
            return ZwrocWynik();
        }

        Task<string> PracujOrazZwrocWynik() {

            return Task.Run(pracujOrazZwrocWynik);
        }

        async Task<string> PracujOrazZwrocWynikAsync2() {
            await Task.Run(PracujMetoda);

            return ZwrocWynik(); 
        }
            
        private async void bnt_asyncAwait1_Click(object sender, RoutedEventArgs e)
        {
            Label_pierwszy.Content = await PracujOrazZwrocWynikAsync2();

        }
    }
}
