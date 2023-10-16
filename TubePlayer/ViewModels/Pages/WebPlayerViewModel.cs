using Wpf.Ui.Controls;

namespace TubePlayer.ViewModels.Pages;

public partial class WebPlayerViewModel : ObservableObject, INavigationAware
{
    [ObservableProperty] 
    private string _webUrl;

    public WebPlayerViewModel()
    {
        WebUrl = "https://youtube.com";
    }
    public void OnNavigatedTo()
    {
    }

    public void OnNavigatedFrom()
    {
    }
}