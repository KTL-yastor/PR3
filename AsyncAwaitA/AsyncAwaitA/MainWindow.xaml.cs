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

namespace AsyncAwaitA
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

        void Pracuj() { Thread.Sleep(3000); }
        void UaktualnijUI() 
        {
            Naglowek.Text = "Praca zakończona o "
                + DateTime.Now.ToString("HH:mm:ss");
        }
        void PracujOrazUaktualnijUI() 
        {
            Pracuj();
            UaktualnijUI();
        }
        private void WatekOkna_Click(object sender, RoutedEventArgs e)
        {
            PracujOrazUaktualnijUI();
        }

        private void NowyWatek_Click(object sender, RoutedEventArgs e)
        {
            Thread watek = new Thread(PracujOrazUaktualnijUI); //to nei zadziala bo prubujemy wykonac interakcje z UI z watku innego niz glowny UI , trzeba uzyc dispatcher
            watek.Start();
        }

        private void OknoKomunikatu_Click(object sender, RoutedEventArgs e)
        {
            Thread watek = new Thread(() => {
                Pracuj();
                //UaktualnijUI();
                MessageBox.Show("Praca zakończona o "
                + DateTime.Now.ToString("HH:mm:ss"),
                "Notyfikacja o zakończeniu pracy");
            });
            watek.Start();   
        }

        private void WatekDispatcherWszystko_Click(object sender, RoutedEventArgs e)
        {
            Thread watek = new Thread(() => {
                // Ta konstrukcja NIE przejdzie - trzeba jawnie podać delegację
                //Dispatcher.BeginInvoke(PracujOrazUaktualnijUI);
                // Ta konstrukcja przejdzie - jawnie podana delegację
                Dispatcher.BeginInvoke(new ThreadStart(PracujOrazUaktualnijUI)); //dispatcher zleca wykonanie watku w watku UI (glownym od okna apki)
                // w sumie to jest to samo co NowyWatek_Click
                // często podawane jest lambda-wyrażenie (będzie później)               
            });
            watek.Start();
        }

        private void WatekDispatcherTylkoNotyfikacja_Click(object sender, RoutedEventArgs e)
        {
            Thread watek = new Thread(() => {
                Pracuj();
                Dispatcher.BeginInvoke(new ThreadStart(UaktualnijUI));
            });
            //tutaj w nowym watku odpalam ciezka prace ktora by mogla cos blokowac, a nastepnie w watku UI uaktualniam UI (watek UI nie jest blokowany)
            watek.Start();
        }

        async private void AwaitTylkoDlaOperacji_Click(object sender, RoutedEventArgs e) //async czyli sa uzywane operacje asynchroniczne
        {
            await Task.Run(Pracuj); //await czyli czekaj na zakonczenie operacji asynchronicznej i wraca do watku UI ktory wykonal await
            UaktualnijUI();
            // Czy można zamiast tego użyć następującej konstrukcji?
            //await Task.Run(PracujOrazUaktualnijUI);
            // Odpowiedź: nie - to samo działanie co dla drugiego przypadku
        }
        string ZwrocWynik()
        {
            return "Praca zakończona o "
                + DateTime.Now.ToString("HH:mm:ss");
        }
        string PracujOrazZwrocWynik()
        {
            Pracuj();
            return ZwrocWynik();
        }
        Task<string> PracujOrazZwrocWynikAsync1() // funkcja zwraca taska ktory zwraca stringa task jest asynch
        {
            return Task.Run(PracujOrazZwrocWynik); 
        }
        async Task<string> PracujOrazZwrocWynikAsync2() //dopisanie async i await nic nie zmienia bo task i tak jest async
        {
            return await Task.Run(PracujOrazZwrocWynik);
        }
        async Task<string> PracujOrazZwrocWynikAsync3()
        {
            await Task.Run(Pracuj); //najpierw to w innym tasku a potem wracamy do watku UI i zwracamy to co trzeba
            return ZwrocWynik();
        }

        private async void AsyncAwait1_Click(object sender, RoutedEventArgs e)
        {
            Naglowek.Text = await PracujOrazZwrocWynikAsync1(); // nic sie nie zawiesi bo glowne UI dalej dziala i dopiero jak zakonczy sie funkcja to wraca do watku UI
        }

        private async void AsyncAwait2_Click(object sender, RoutedEventArgs e)
        {
            Naglowek.Text = await PracujOrazZwrocWynikAsync2(); // to samo 
        }

        async private void AsyncAwait3_Click(object sender, RoutedEventArgs e)
        {
            Naglowek.Text = await PracujOrazZwrocWynikAsync3();
        }
    }
}
