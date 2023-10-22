using NewsApp.ViewModel;

namespace NewsApp.View;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(NewsDetailViewModel newsDetailPageModel)
	{
		InitializeComponent();
        BindingContext =  newsDetailPageModel;
    }
}