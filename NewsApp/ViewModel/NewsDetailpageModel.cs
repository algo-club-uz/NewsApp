using CommunityToolkit.Mvvm.ComponentModel;
using NewsApp.Model;

namespace NewsApp.ViewModel;

[QueryProperty(nameof(User), "UserKey")]
public partial class NewsDetailPageModel:ObservableObject
{
    [ObservableProperty] 
    private User user;
}