﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChristmasShoppingCart.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoppingCartView : ContentPage
    {
        public ShoppingCartView()
        {
            InitializeComponent();

            BindingContext = new ViewModels.ShoppingCartViewModel();

            SizeChanged += (sender, args) =>
            {
                var height = Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Height;

                if (height < 1150)
                {
                   VisualStateManager.GoToState(ItemsList, "SmallScreen");
                   VisualStateManager.GoToState(TotalLabel, "SmallScreen");
                }
            };
        }
    }
}