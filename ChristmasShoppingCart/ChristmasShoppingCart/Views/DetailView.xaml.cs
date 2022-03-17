using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChristmasShoppingCart.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailView : ContentPage
    {
        public DetailView()
        {
            InitializeComponent();

            SizeChanged += (sender, args) =>
            {
                var height = Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Height;

                if (height < 1150)
                {
                    VisualStateManager.GoToState(ProductImage, "SmallScreen");
                    VisualStateManager.GoToState(ProductName, "SmallScreen");
                    VisualStateManager.GoToState(ProductPrice, "SmallScreen");
                    VisualStateManager.GoToState(ProductDescription, "SmallScreen");
                }
            };
        }
    }
}