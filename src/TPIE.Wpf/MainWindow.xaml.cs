using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using TPIE.Data;

namespace TPIE.Wpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddWpfBlazorWebView();
        serviceCollection.AddBlazorWebViewDeveloperTools();
        serviceCollection.AddSingleton<WeatherForecastService>();
        Resources.Add("services", serviceCollection.BuildServiceProvider());
    }
}
