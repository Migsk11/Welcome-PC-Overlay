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

namespace front_wpf;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Window mainWindow = (Window)FindName("mainWindow");
        Storyboard boasVindasFadeInFadeOut = (Storyboard)FindResource("BoasVindas-FadeInFadeOut");

        Label labelTimeAndDate = (Label)FindName("TimeAndDate");
        DateOnly actualDate = DateOnly.FromDateTime(DateTime.Now);
        
        labelTimeAndDate.Content = actualDate.ToString("dd") + " de " + actualDate.ToString("MMMM") + " de " + actualDate.ToString("yyyy"); 


        boasVindasFadeInFadeOut.Completed += (_, _) =>
        {
            mainWindow.Close();
        };
        
            
        boasVindasFadeInFadeOut.Begin();
        
    }
}