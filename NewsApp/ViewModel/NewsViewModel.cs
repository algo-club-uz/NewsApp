using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NewsApp.View;

namespace NewsApp.ViewModel;

public partial class NewsViewModel:ObservableObject
{
    [ObservableProperty]
     string username;

    [RelayCommand]
     void Login()
     {
         Shell.Current.Navigation.PushAsync(new NewsDetailPage());
     }

}