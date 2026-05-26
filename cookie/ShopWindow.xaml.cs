using cookie;
using System;
using System.Windows;

namespace cookie
{
    public partial class ShopWindow : Window
    {
        MainWindow main;

        // PRICES

        double cursorPrice = 10;

        double doublePrice = 50;

        double grandmaPrice = 100;

        double bakeryPrice = 500;

        double factoryPrice = 2500;

        public ShopWindow(MainWindow window)
        {
            InitializeComponent();

            main = window;

            UpdatePrices();
        }

        // UPDATE BUTTON PRICES

        private void UpdatePrices()
        {
            CursorButton.Content =
                "🥤 BIGGER SIP (+1 click) - " +
                Math.Round(cursorPrice);

            DoubleButton.Content =
                "⚡ RAGE BOOST (+5 click) - " +
                Math.Round(doublePrice);

            GrandmaButton.Content =
                "👤 UNDERGROUND PLUG (+1/sec) - " +
                Math.Round(grandmaPrice);

            BakeryButton.Content =
                "🎵 STUDIO SESSION (+5/sec) - " +
                Math.Round(bakeryPrice);

            FactoryButton.Content =
                "🚗 TONKA FACTORY (+25/sec) - " +
                Math.Round(factoryPrice);
        }

        // BIGGER SIP

        private void Cursor_Click(object sender, RoutedEventArgs e)
        {
            if (main.cups >= cursorPrice)
            {
                main.cups -= cursorPrice;

                main.cupsPerClick += 1;

                cursorPrice =
                    Math.Round(cursorPrice * 1.5);

                main.totalUpgrades++;

                main.UpdateUI();

                UpdatePrices();
            }
            else
            {
                MessageBox.Show("NOT ENOUGH DRANK 💀");
            }
        }

        // RAGE BOOST

        private void Double_Click(object sender, RoutedEventArgs e)
        {
            if (main.cups >= doublePrice)
            {
                main.cups -= doublePrice;

                main.cupsPerClick += 5;

                doublePrice =
                    Math.Round(doublePrice * 1.5);

                main.totalUpgrades++;

                main.UpdateUI();

                UpdatePrices();
            }
            else
            {
                MessageBox.Show("NOT ENOUGH DRANK 💀");
            }
        }

        // UNDERGROUND PLUG

        private void Grandma_Click(object sender, RoutedEventArgs e)
        {
            if (main.cups >= grandmaPrice)
            {
                main.cups -= grandmaPrice;

                main.cupsPerSecond += 1;

                grandmaPrice =
                    Math.Round(grandmaPrice * 1.5);

                main.totalUpgrades++;

                main.UpdateUI();

                UpdatePrices();
            }
            else
            {
                MessageBox.Show("NOT ENOUGH DRANK 💀");
            }
        }

        // STUDIO SESSION

        private void Bakery_Click(object sender, RoutedEventArgs e)
        {
            if (main.cups >= bakeryPrice)
            {
                main.cups -= bakeryPrice;

                main.cupsPerSecond += 5;

                bakeryPrice =
                    Math.Round(bakeryPrice * 1.5);

                main.totalUpgrades++;

                main.UpdateUI();

                UpdatePrices();
            }
            else
            {
                MessageBox.Show("NOT ENOUGH DRANK 💀");
            }
        }

        // TONKA FACTORY

        private void Factory_Click(object sender, RoutedEventArgs e)
        {
            if (main.cups >= factoryPrice)
            {
                main.cups -= factoryPrice;

                main.cupsPerSecond += 25;

                factoryPrice =
                    Math.Round(factoryPrice * 1.5);

                main.totalUpgrades++;

                main.UpdateUI();

                UpdatePrices();
            }
            else
            {
                MessageBox.Show("NOT ENOUGH DRANK 💀");
            }
        }
    }
}