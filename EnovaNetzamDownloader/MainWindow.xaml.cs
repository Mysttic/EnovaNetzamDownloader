using EnovaNetzamDownloader.Properties;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EnovaNetzamDownloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            VersionCB.ItemsSource = Settings.Default.SavedVersions;
        }

        private void VersionCB_TextChanged(object sender, TextChangedEventArgs e)
        {
            StackPanelSP.IsEnabled = Tools.VerifyVersion(VersionCB.Text);
        }

        private void InstalatorEnovaExeBT_Click(object sender, RoutedEventArgs e) => Tools.Download(Settings.Default.InstalatorEnovaExe, VersionCB.Text);

        private void InstalatorEnovaMsiBT_Click(object sender, RoutedEventArgs e) => Tools.Download(Settings.Default.InstalatorEnovaMsi, VersionCB.Text);

        private void InstalatorEnovaZipBT_Click(object sender, RoutedEventArgs e) => Tools.Download(Settings.Default.InstalatorEnovaZip, VersionCB.Text);

        private void UlotkaDoWersjiBT_Click(object sender, RoutedEventArgs e) => Tools.Download(Settings.Default.UlotkaDoWersji, VersionCB.Text);

        private void KomunikatDlaKlientaBT_Click(object sender, RoutedEventArgs e) => Tools.Download(Settings.Default.KomunikatDlaKlienta, VersionCB.Text);

        private void WykazZmianProgramistycznychBT_Click(object sender, RoutedEventArgs e) => Tools.Download(Settings.Default.WykazZmianProgramistycznych, VersionCB.Text);
    }
}
