using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NewsApp.ViewModel;

public partial class NewsViewModel:ObservableObject
{
    [ObservableProperty]
     string username;

    [RelayCommand]
     void Login()
     {

     }

}