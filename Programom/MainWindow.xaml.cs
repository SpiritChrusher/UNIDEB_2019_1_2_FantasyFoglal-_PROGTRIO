using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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

        private void Hungary_Click(object sender, RoutedEventArgs e)
        {
            Popup codePopup = new Popup();
            TextBlock popupText = new TextBlock();
            popupText.Text = "Ez a funkció még yet to come";
            popupText.Background = Brushes.LightBlue;
            popupText.Foreground = Brushes.Blue;
            codePopup.Child = popupText;
        }

        private void Középfölde_Click(object sender, RoutedEventArgs e)
        {
            Middle_Earth középföld = new Middle_Earth();
            this.Content = középföld; 
        }

        private void Star_Wars_Click(object sender, RoutedEventArgs e)
        {
            Star_Wars tatooine = new Star_Wars();
            this.Content = tatooine;
        }
    }
}
