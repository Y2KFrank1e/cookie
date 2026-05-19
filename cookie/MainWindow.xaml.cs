using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace cookie
{
    public partial class MainWindow : Window
    {
        // GAME VALUES

        public double cookies = 0;

        public double cookiesPerClick = 1;

        public double cookiesPerSecond = 0;

        public int totalClicks = 0;

        public int totalUpgrades = 0;

        // TIMER

        DispatcherTimer timer = new DispatcherTimer();

        // SHOP WINDOW

        ShopWindow shop;

        public MainWindow()
        {
            InitializeComponent();

            // TIMER SETTINGS

            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += Timer_Tick;

            timer.Start();

            UpdateUI();
        }

        // AUTO PRODUCTION

        private void Timer_Tick(object sender, EventArgs e)
        {
            cookies += cookiesPerSecond;

            UpdateUI();
        }

        // CLICKING CUP

        private void Cookie_Click(object sender, RoutedEventArgs e)
        {
            cookies += cookiesPerClick;

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

        // UPDATE TEXTS

        public void UpdateUI()
        {
            CookiesText.Text =
                "CUPS: " + Math.Floor(cookies);

            ClickText.Text =
                "DRANK PER CLICK: " +
                cookiesPerClick;

            SecondText.Text =
                "FLOW PER SECOND: " +
                cookiesPerSecond;

            StatsText.Text =
                "TOTAL CLICKS: " + totalClicks +
                "\nUPGRADES: " + totalUpgrades;
        }

        // CUP ROTATION ANIMATION

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

        // CLICK SOUND

        private void PlayClickSound()
        {
            SystemSounds.Asterisk.Play();
        }
    }
}