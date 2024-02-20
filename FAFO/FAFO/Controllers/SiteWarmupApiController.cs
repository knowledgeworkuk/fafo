using KnowledgeWork.FAFO.Services;
using Microsoft.AspNetCore.Mvc;
using Smidge.Hashing;
using Umbraco.Cms.Core.Security;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Services.Implement;
using Umbraco.Cms.Web.BackOffice.Controllers;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.Security;

namespace KnowledgeWork.FAFO.Controllers
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
