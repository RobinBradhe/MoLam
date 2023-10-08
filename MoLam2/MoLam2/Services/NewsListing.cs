using MoLam2.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;

namespace MoLam2.Services
{
    public class NewsListing : INewsListing
    {
        private readonly UmbracoHelper _umbracoHelper;

        public NewsListing(UmbracoHelper umbracoHelper)
            => _umbracoHelper = umbracoHelper;

        public IEnumerable<NewsPage> GetAllNewsFromStartPageNode()
        {
            var startPage = _umbracoHelper.ContentAtRoot().FirstOrDefault() as StartPage;
            if(startPage == null)
                return Enumerable.Empty<NewsPage>();

            return startPage!.Newslistpage!.Children<NewsPage>();
        }
    }
}
