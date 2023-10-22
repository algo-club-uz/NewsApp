using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NewsApp.Model;
using NewsApp.Services;
using NewsApp.View;

namespace NewsApp.ViewModel;

public partial class NewsViewModel:ObservableObject
{

    private readonly MockNewsService _newsService;
    public ObservableCollection<News> NewsCollection { get;  set; } = new ObservableCollection<News>();

    public NewsViewModel(MockNewsService newsService)
    {
        _newsService = newsService;
        GetNewsList();
    }

    private void GetNewsList()
    {
      var news =    _newsService.GetNews();
      foreach (var item in news)
      {
          NewsCollection.Add(item);
      }
    }

    [ObservableProperty]
    private News selectedNews;

    [RelayCommand]
    void GoToDetails()
    {
        Shell.Current.GoToAsync($"{nameof(NewsDetailPage)}",
            new Dictionary<string, object>
            {
                {"News",}
            });

    }
}