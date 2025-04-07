using NewsApp.MVVM.ViewModel;

namespace NewsApp.MVVM.View;

public partial class NewsPage : ContentPage
{
	public NewsPage(NewsViewModel newsViewModel)
	{
		InitializeComponent();
		BindingContext = newsViewModel;
	}
}