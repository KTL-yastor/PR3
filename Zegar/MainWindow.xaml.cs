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
using System.Windows.Threading;

namespace Zegar
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer dt;
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void bnt_Start_Click(object sender, RoutedEventArgs e)
        {
            //dt_Tick = 1;
            if (dt == null)
            {
                dt = new DispatcherTimer();
                dt.Interval = TimeSpan.FromSeconds(1);
                lb_time.Content = DateTime.Now.ToString("HH:mm:ss"); // początkowa wartość bo inaczej trzeba czekac 1 sek zanim cos wyswietli
                dt.Tick += Zdarzenie_Tick; // += to operator dodawania zdarzenia do listy zdarzen (chyba jest delegatem)
                
            }
            dt.Start();
        }

        private void Zdarzenie_Tick(object sender, EventArgs e)
        {

            lb_time.Content = DateTime.Now.ToString("HH:mm:ss");
            //throw new NotImplementedException();
        }

        private void bnt_Stop_Click(object sender, RoutedEventArgs e)
        {
            if (dt != null)
            {
                dt.Stop();
                dt = null;
                lb_time.Content = "[Off]";
            }
        }
    }
}
