using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NewsApp.MVVM.Model;
using NewsApp.MVVM.View;
using NewsApp.Services;
using System.Collections.ObjectModel;

namespace NewsApp.MVVM.ViewModel;

public partial class NewsViewModel:ObservableObject
{
    private NewsService newsService;

    public ObservableCollection<News> NewsCollection { get; set; } =new ObservableCollection<News>();

    public NewsViewModel(NewsService newsService)
    {
        this.newsService = newsService;
        GetNewsList();
    }

    private async void GetNewsList()
    {
        var result= await newsService.GetNews();
        foreach (var item in result)
        {
            NewsCollection.Add(item);
        }
    }

    

    [ObservableProperty]
    News selectedNews;


    [RelayCommand]
    async Task GoToDetails()
    {
        if (SelectedNews != null)
        {
            await Shell.Current.GoToAsync(nameof(NewsDetailPage),
                new Dictionary<string, object>
                {
                {"SelectedNews1", SelectedNews} // یا "News" اگر در NewsDetailViewModel تغییر دادید
                });

            SelectedNews = null; // Reset selection
        }
    }
}

//public class NewsViewModel
//{
//    public Command SignInCommand { get; set; }

//    private string userName;
//    public string UserName { get { return userName; } set { userName = value; } }



//    public NewsViewModel()
//    {
//        SignInCommand = new Command(SignIn);
//    }

//    private void SignIn(object obj)
//    {

//    }
//}
