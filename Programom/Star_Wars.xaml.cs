using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Runtime.CompilerServices;
using System.ComponentModel;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace Programom
{
    /// <summary>
    /// Interaction logic for Star_Wars.xaml
    /// </summary>
    public partial class Star_Wars : Page // INotifyPropertyChanged
    {
        /*   private int pontok;

           public int Pontok
           {
               get { return pontok; }
               set
               {
                   pontok = value;
                   OnPropertyChanged("Pontok");
               }
           }

           public event PropertyChangedEventHandler PropertyChanged;

           private void OnPropertyChanged(string propertyName)
           {
               if (PropertyChanged != null)
                   PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
           }*/
        Player játékos = Player.gamers[0];

        public Star_Wars()
        {
            DataContext = játékos;
            InitializeComponent();

            //this.DataContext = null;
            //this.DataContext = DataModel;
            //    var mySource = Enumerable.Range(1, 1000).ToList();
            //  Task.Factory.StartNew(() => CalculateMyOperation(mySource));
          //  Pointtable.Text = Player.gamers[0].Name + " pontja: " +  Player.gamers[0].Points;

        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {

            App.Current.Shutdown();

        }

      
        private void Középgomb_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Gomb1_Click(object sender, RoutedEventArgs e)
        {

            //Player.Pointincrease(Player.gamers[0]);
            // játékos.Points += 100;

            //Valahol outofrangeexception van abban az osztályban.


            Questions ablak = new Questions();

            ablak.Show();
        }

        private void Gomb2_Click(object sender, RoutedEventArgs e)
        {

            Questions ablak = new Questions();

            ablak.Show();
        }

        private void Gomb3_Click(object sender, RoutedEventArgs e)
        {
            Questions ablak = new Questions();

            ablak.Show();
        }

        private void Gomb4_Click(object sender, RoutedEventArgs e)
        {
            Questions ablak = new Questions();

            ablak.Show();
        }

        private void Gomb5_Click(object sender, RoutedEventArgs e)
        {
            Questions ablak = new Questions();

            ablak.Show();

        }

        private void Gomb6_Click(object sender, RoutedEventArgs e)
        {
            Questions ablak = new Questions();
            ablak.Show();

        }

        private void Gomb7_Click(object sender, RoutedEventArgs e)
        {
            Questions ablak = new Questions();
            
            ablak.Show();

        }

        private void Gomb8_Click(object sender, RoutedEventArgs e)
        {
            Questions ablak = new Questions();

            ablak.Show();

        }

        private void Gomb9_Click(object sender, RoutedEventArgs e)
        {
            Questions ablak = new Questions();

            ablak.Show();

        }
    }
}
