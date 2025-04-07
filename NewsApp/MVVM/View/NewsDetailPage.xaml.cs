using NewsApp.MVVM.ViewModel;

namespace NewsApp.MVVM.View;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(NewsDetailViewModel newsDetailViewModel)
	{
		InitializeComponent();
		BindingContext= newsDetailViewModel;

	}
}