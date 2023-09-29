using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using MoLam2.Models.ViewModels;
using MoLam2.Services;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.Controllers;

namespace MoLam2.Controllers
{
    public class StartPageController : RenderController
	{
        private readonly IVariationContextAccessor _variationContextAccessor;
        private readonly ServiceContext _serviceContext;
        private readonly INewsListing _newsListing;


        public StartPageController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor,
             IVariationContextAccessor variationContextAccessor, ServiceContext context, INewsListing newsListing, UmbracoHelper umbracoHelper)
		: base(logger, compositeViewEngine, umbracoContextAccessor)
		{
            _variationContextAccessor = variationContextAccessor;
            _serviceContext = context;
            _newsListing = newsListing;
        }

        public IActionResult StartPage()
		{
            ViewData["Title"] = "hioehieohi";
            var viewModel = new StartPageViewModel(CurrentPage!, new PublishedValueFallback(_serviceContext, _variationContextAccessor))
            {
                //TODO add rootnode
                NewsList = _newsListing.GetAllNewsFromStartPageNode()
            };
			return View(viewModel);
		}

	}
}
