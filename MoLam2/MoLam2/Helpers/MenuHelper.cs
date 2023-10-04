using MoLam2.Models.ViewModels;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace MoLam2.Helpers
{
    public static class MenuHelper
    {

        public static async Task<IEnumerable<NavigationModel>> GetNavigationModels(this IEnumerable<IPublishedContent> originalList)
        {
            if (!originalList.Any())
                return Enumerable.Empty<NavigationModel>();

            var nav = new List<NavigationModel>();
            foreach (var item in originalList.Where(x => x.IsVisible()))
            {
                nav.Add(new NavigationModel()
                {
                    Name = item!.Name,
                    Title = item!.Name,
                    Url = item.Url()
                });


            }
            return await Task.FromResult(nav);

        }
    }
}
