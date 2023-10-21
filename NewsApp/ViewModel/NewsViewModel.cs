using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NewsApp.Model;
using NewsApp.View;

namespace NewsApp.ViewModel;

public partial class NewsViewModel:ObservableObject
{
    [ObservableProperty]
     string username;

    [RelayCommand]
     void Login()
     {
         var user = new User()
         {
             Name = "Maruf",
             Email = "fuga02@gmail.com",
             Phone = "931544780"
         };

         Shell.Current.GoToAsync($"{nameof(NewsDetailPage)}",new Dictionary<string, object>
         {
             {"UserKey",user}
         });
     }

}