using CommunityToolkit.Mvvm.ComponentModel;

namespace NewsApp.ViewModel;

[QueryProperty(nameof(User_name),"username")]
public partial class NewsDetailPageModel:ObservableObject
{
    [ObservableProperty]
     string user_name;
}