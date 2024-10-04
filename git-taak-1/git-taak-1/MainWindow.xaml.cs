using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace git_taak_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rood_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Red;
        }

        private void geel_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Yellow;
        }

        private void groen_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Green;
        }

        private void blauw_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Blue;
        }

        private void rood_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void geel_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void groen_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void blauw_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void rood_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorcodeTextBox.Text = "#FF0000";
            informationTextBox.Text = "Rood is de kleur van warmte";
        }

        private void geel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorcodeTextBox.Text = "#FFFF00";
            informationTextBox.Text = "Geel is de kleur van levenslust";
        }

        private void groen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorcodeTextBox.Text = "#008000";
            informationTextBox.Text = "Groen is de kleur van genezing";
        }

        private void blauw_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorcodeTextBox.Text = "#0000FF";
            informationTextBox.Text = "Blauw is de kleur van intelligentie";
        }

        
    }
}