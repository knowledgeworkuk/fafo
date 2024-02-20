using KnowledgeWork.SiteWarmupDashboard.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.BackOffice.Controllers;
using Umbraco.Cms.Web.Common;

namespace KnowledgeWork.SiteWarmupDashboard.Controllers
{
    public class SiteWarmupApiController : UmbracoAuthorizedApiController
    {

        private UmbracoHelper _helper;
        private IContentService _contentService;

        public SiteWarmupApiController(UmbracoHelper umbracoHelper, IContentService contentService)
        {
            _helper = umbracoHelper;
            _contentService = contentService;
        }


        [HttpGet]
        public JsonResult GetPages()
        {
            var contentService = new ContentAdminService(_helper);

            var pages = contentService.GetPageList();

            return new JsonResult(pages);
        }
    }
}
