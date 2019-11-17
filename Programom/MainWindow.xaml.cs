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

namespace Programom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public class Sajt
    {
        public string előnév;
        public string utónév;
        public bool id;

        public string Name()
        { return előnév + " " + utónév; }

    }
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


        }
        private void Szövegbuborék_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Elsőszöveg_MouseEnter(object sender, MouseEventArgs e)
        {
            /*    Hungary_map térkép = new Hungary_map();
                térkép.Show();*/
         //   Hungary kép = new Hungary();
           // this.Content = kép;
        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
