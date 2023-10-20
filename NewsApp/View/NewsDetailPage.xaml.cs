using NewsApp.ViewModel;

namespace NewsApp.View;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage()
	{
		InitializeComponent();
        BindingContext = new NewsDetailPageModel();
    }
}