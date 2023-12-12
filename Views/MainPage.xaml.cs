using MiChatGPTDani.ViewModels;
namespace MiChatGPTDani.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModels mainPageViewModels)
    {
        InitializeComponent();
        BindingContext = mainPageViewModels;
    }
}