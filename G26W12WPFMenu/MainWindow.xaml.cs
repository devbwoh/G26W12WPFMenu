using System.Windows;

namespace G26W12WPFMenu;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        DataContext = new MenuViewModel(new MenuModel());
    }
}