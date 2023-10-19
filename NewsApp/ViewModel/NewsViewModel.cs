using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace NewsApp.ViewModel;

public partial class NewsViewModel:ObservableObject
{
    [ObservableProperty]
     string username;

}