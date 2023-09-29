using MoLam2.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace MoLam2.Services
{
    //Should interface be in their own folder? 
    public interface INewsListing
    {
        IEnumerable<NewsPage> GetAllNewsFromStartPageNode();
    }
}
