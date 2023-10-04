using MoLam2.Helpers;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace MoLam2.Models.ViewModels
{
    public class NavigationModel
    {
        public NavigationModel()
        {
        }

        public NavigationModel(IEnumerable<IPublishedContent> publishedContents)
        {
            ChildItems = publishedContents.GetNavigationModels();
        }

        public Task<IEnumerable<NavigationModel>> ChildItems { get; set; }

        public string Name { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
    }
}
