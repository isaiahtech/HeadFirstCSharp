﻿using System;
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

namespace discountSandwiches
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            for (int i = 0; i < 5; i++)
            {
                if (i <3)
                {
                    menuItems[i] = new MenuItem();
                } else
                {
                    menuItems[i] = new MenuItem()
                    {
                        Breads = new string[] { "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel" }
                    };
                }
            }

            item1.Text = menuItems[0].GenerateMenuItem();
            price1.Text = menuItems[0].RandomPrice();
            item2.Text = menuItems[1].GenerateMenuItem();
            price2.Text = menuItems[1].RandomPrice();
            item3.Text = menuItems[2].GenerateMenuItem();
            price3.Text = menuItems[2].RandomPrice();
            item4.Text = menuItems[3].GenerateMenuItem();
            price4.Text = menuItems[3].RandomPrice();
            item5.Text = menuItems[4].GenerateMenuItem();
            price5.Text = menuItems[4].RandomPrice();

            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" },
                Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
            };

            item6.Text = specialMenuItem.GenerateMenuItem();
            price6.Text = specialMenuItem.RandomPrice();

            guacamole.Text = "Add guacamole for " + specialMenuItem.RandomPrice();
        }
    }

    class MenuItem
    {
        public Random Randomizer = new Random();

        public string[] Proteins = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };

        public string GenerateMenuItem()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomProtein + " with " + randomCondiment + " on " + randomBread;
        }

        public string RandomPrice()
        {
            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * .01M);
            return price.ToString("c");
        }
    }
}