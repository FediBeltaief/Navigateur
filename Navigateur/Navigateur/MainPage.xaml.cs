using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigateur
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void NavPage1(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page1());
        }
        public void NavPage2(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page2());
        }
        public void NavPage3(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page3());
        }
    }
}
