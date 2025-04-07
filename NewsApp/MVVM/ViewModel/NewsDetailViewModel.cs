using CommunityToolkit.Mvvm.ComponentModel;
using NewsApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.MVVM.ViewModel;

[QueryProperty(nameof(News), "SelectedNews1")] // یا "News" اگر در NewsViewModel تغییر دادید
public partial class NewsDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private News news;

    // Constructor را ساده نگه دارید
    public NewsDetailViewModel()
    {
    }
}
