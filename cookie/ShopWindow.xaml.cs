using System;
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
using System.Windows.Shapes;

namespace cookie
{
    /// <summary>
    /// Interakční logika pro ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
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
            }

            // BIGGER SIP

            private void Cursor_Click(object sender, RoutedEventArgs e)
            {
                if (main.cookies >= cursorPrice)
                {
                    main.cookies -= cursorPrice;

                    main.cookiesPerClick += 1;

                    cursorPrice =
                        Math.Round(cursorPrice * 1.5);

                    main.totalUpgrades++;

                    main.UpdateUI();
                }
                else
                {
                    MessageBox.Show(
                        "NOT ENOUGH DRANK 💀");
                }
            }

            // RAGE BOOST

            private void Double_Click(object sender, RoutedEventArgs e)
            {
                if (main.cookies >= doublePrice)
                {
                    main.cookies -= doublePrice;

                    main.cookiesPerClick += 5;

                    doublePrice =
                        Math.Round(doublePrice * 1.5);

                    main.totalUpgrades++;

                    main.UpdateUI();
                }
                else
                {
                    MessageBox.Show(
                        "NOT ENOUGH DRANK 💀");
                }
            }

            // UNDERGROUND PLUG

            private void Grandma_Click(object sender, RoutedEventArgs e)
            {
                if (main.cookies >= grandmaPrice)
                {
                    main.cookies -= grandmaPrice;

                    main.cookiesPerSecond += 1;

                    grandmaPrice =
                        Math.Round(grandmaPrice * 1.5);

                    main.totalUpgrades++;

                    main.UpdateUI();
                }
                else
                {
                    MessageBox.Show(
                        "NOT ENOUGH DRANK 💀");
                }
            }

            // STUDIO SESSION

            private void Bakery_Click(object sender, RoutedEventArgs e)
            {
                if (main.cookies >= bakeryPrice)
                {
                    main.cookies -= bakeryPrice;

                    main.cookiesPerSecond += 5;

                    bakeryPrice =
                        Math.Round(bakeryPrice * 1.5);

                    main.totalUpgrades++;

                    main.UpdateUI();
                }
                else
                {
                    MessageBox.Show(
                        "NOT ENOUGH DRANK 💀");
                }
            }

            // TONKA FACTORY

            private void Factory_Click(object sender, RoutedEventArgs e)
            {
                if (main.cookies >= factoryPrice)
                {
                    main.cookies -= factoryPrice;

                    main.cookiesPerSecond += 25;

                    factoryPrice =
                        Math.Round(factoryPrice * 1.5);

                    main.totalUpgrades++;

                    main.UpdateUI();
                }
                else
                {
                    MessageBox.Show(
                        "NOT ENOUGH DRANK 💀");
                }
            }
        }
    }
}