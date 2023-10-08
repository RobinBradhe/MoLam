using MoLam2.Models.CustomModels;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace MoLam2.Models.ViewModels
{
    public class StartPageViewModel : PublishedContentWrapped
    {
        public StartPageViewModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback) : 
            base(content, publishedValueFallback)
          =>  CurrentPage = (StartPage)content!;
        

        public StartPage CurrentPage { get; set; }
        public PaginatedPages<NewsPage> PaginatedPages { get; set; }

    }
}
