using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using WinUITeachingTipBug.ViewModel;

namespace WinUITeachingTipBug
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MainPageViewModel ViewModel;
        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new MainPageViewModel();
        }

        private void RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            e.Handled = true;
            if (e.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Mouse)
            {
                if ((e.OriginalSource as FrameworkElement).DataContext is TestModel model)
                {
                    model.RightClickOpen = true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NewPage));
        }
    }
}
