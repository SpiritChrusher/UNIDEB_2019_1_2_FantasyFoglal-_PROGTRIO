using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imtrying
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        


        public MainPage()
        {

            InitializeComponent();

            var assembly = typeof(MainPage);

            //   ImageSource imageSource = fantasy.Source = ImageSource.FromResource("imtrying.Assets.Images.fantasy_bkgrd.png", assembly);
            ImageSource imageSource = ImageSource.FromResource("imtrying.Assets.Images.fantasy_bkgrd.png", assembly);
        }

        private void SW_Clicked(object sender, EventArgs e)
        {
            bool isNameempty = string.IsNullOrEmpty(Nameplace.Text);
            if (isNameempty) 
            {
                Nameplace.Placeholder = "Please write in your name!";
            }
                else {
                Navigation.PushAsync(new StarWars_Page(), true);

            }
        }

        private void test_Clicked(object sender, EventArgs e)
        {
         /*   bool isNameempty = string.IsNullOrEmpty(Nameplace.Text);
            if (isNameempty || Player.Namechecker(Nameplace.Text))
            {
                Nameplace.Placeholder = "Please write in your name!";
            }
            else
            {*/

                Player gamer = new Player();
                gamer.Name = Nameplace.Text;               
                Player.gamers.Add(gamer);
                Navigation.PushAsync(new TesztPage1(), true);

            //}
        }
    }
}
