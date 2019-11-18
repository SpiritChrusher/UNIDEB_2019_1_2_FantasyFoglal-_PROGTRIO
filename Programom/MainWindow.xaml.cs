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
    

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


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
            Player gamer = new Player();
              gamer.Name = namebox.Text;
             gamer.Color =  colorbox.Text;
             Player.gamers.Add(gamer);


            Star_Wars tatooine = new Star_Wars();
            this.Content = tatooine;
        }
    }
}
