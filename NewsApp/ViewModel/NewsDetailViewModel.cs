using CommunityToolkit.Mvvm.ComponentModel;
using NewsApp.Model;

namespace NewsApp.ViewModel;

[QueryProperty(nameof(news),"News")]
public partial class NewsDetailViewModel:ObservableObject
{
    [ObservableProperty]
     News news;
}