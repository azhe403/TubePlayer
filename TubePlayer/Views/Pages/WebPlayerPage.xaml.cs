using System.Windows.Controls;
using Microsoft.Web.WebView2.Core;
using TubePlayer.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace TubePlayer.Views.Pages;

public partial class WebPlayerPage : INavigableView<WebPlayerViewModel>
{
    public WebPlayerViewModel ViewModel { get; }
    
    public WebPlayerPage(WebPlayerViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;
        
        InitializeComponent();

        WebPlayer.SourceChanged += OnWebViewSourceChanged;
        WebPlayer.NavigationCompleted += WebViewOnNavigationCompleted;
        
        Environment.SetEnvironmentVariable("WEBVIEW2_USER_DATA_FOLDER", @"C:\MyDirectory\", EnvironmentVariableTarget.Process);
    }

    private void WebViewOnNavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
    {

    }

    private void OnWebViewSourceChanged(object? sender, CoreWebView2SourceChangedEventArgs e)
    {
    }
}