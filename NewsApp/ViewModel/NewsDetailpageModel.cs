using CommunityToolkit.Mvvm.ComponentModel;
using NewsApp.Model;

namespace NewsApp.ViewModel;

[QueryProperty(nameof(News),"News")]
public partial class NewsDetailPageModel:ObservableObject
{
    [ObservableProperty]
    private News news;
}