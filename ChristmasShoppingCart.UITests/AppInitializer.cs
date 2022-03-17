﻿using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ChristmasShoppingCart.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp("com.ernox.christmasshoppingcart")
                                           .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}