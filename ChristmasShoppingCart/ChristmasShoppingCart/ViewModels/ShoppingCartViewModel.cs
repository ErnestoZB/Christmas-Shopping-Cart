using ChristmasShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChristmasShoppingCart.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ObservableCollection<Item> Items { get; set; }

        public ShoppingCartViewModel()
        {
            Items = new ObservableCollection<Item>
            {
                new Item
                {
                    Picture="Details1",
                    Title = "Corgi Bear Sewing Supplies",
                    By ="By Fluffmonger",
                    Quantity = "x1",
                    Price = "$50.99"
                },
                new Item
                {
                    Picture="Details2",
                    Title = "Reindeer Crochet Hat",
                    By ="By EmmasToys",
                    Quantity = "x1",
                    Price = "$30.87"
                },
                new Item
                {
                    Picture="Details3",
                    Title = "Reindeer Socks Power Blue",
                    By ="By TheWarmCats",
                    Quantity = "x1",
                    Price = "$8.56"
                }
            };
        }
    }
}
