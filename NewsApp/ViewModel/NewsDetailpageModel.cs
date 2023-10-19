using CommunityToolkit.Mvvm.ComponentModel;

namespace NewsApp.ViewModel;

[QueryProperty(nameof(user_name),"username")]
public partial class NewsDetailpageModel_:ObservableObject
{
    [ObservableProperty]
     string user_name;
}