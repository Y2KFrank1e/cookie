using System;
using System.Media;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Media.Animation;
using System.Windows.Media;

namespace cookie
{
    public partial class MainWindow : Window
    {
        public double cups = 0;

        public double cupsPerClick = 1;

        public double cupsPerSecond = 0;

        public int totalClicks = 0;

        public int totalUpgrades = 0;

        DispatcherTimer timer = new DispatcherTimer();

        ShopWindow shop;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += Timer_Tick;

            timer.Start();

            UpdateUI();
        }

        // AUTO FLOW

        private void Timer_Tick(object sender, EventArgs e)
        {
            cups += cupsPerSecond;

            UpdateUI();
        }

        // CLICK CUP

        private void Cookie_Click(object sender, RoutedEventArgs e)
        {
            cups += cupsPerClick;

            totalClicks++;

            UpdateUI();

            AnimateCup();

            PlayClickSound();
        }

        // OPEN SHOP

        private void OpenShop_Click(object sender, RoutedEventArgs e)
        {
            if (shop == null || !shop.IsLoaded)
            {
                shop = new ShopWindow(this);

                shop.Show();
            }
            else
            {
                shop.Focus();
            }
        }

        // UPDATE UI

        public void UpdateUI()
        {
            CookiesText.Text =
                "CUPS: " + Math.Floor(cups);

            ClickText.Text =
                "DRANK PER CLICK: " +
                cupsPerClick;

            SecondText.Text =
                "FLOW PER SECOND: " +
                cupsPerSecond;

            StatsText.Text =
                "TOTAL CLICKS: " + totalClicks +
                "\nUPGRADES: " + totalUpgrades;
        }

        // ANIMATION

        private void AnimateCup()
        {
            DoubleAnimation rotate =
                new DoubleAnimation();

            rotate.From = -10;

            rotate.To = 10;

            rotate.Duration =
                TimeSpan.FromMilliseconds(100);

            rotate.AutoReverse = true;

            rotate.RepeatBehavior =
                new RepeatBehavior(2);

            CupRotate.BeginAnimation(
                RotateTransform.AngleProperty,
                rotate);
        }

        // SOUND

        private void PlayClickSound()
        {
            SystemSounds.Asterisk.Play();
        }
    }
}