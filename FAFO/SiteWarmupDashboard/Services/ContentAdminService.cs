using KnowledgeWork.SiteWarmupDashboard.Models;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;
using Umbraco.Extensions;
using static Umbraco.Cms.Core.Constants.HttpContext;

namespace KnowledgeWork.SiteWarmupDashboard.Services
{
    public class ContentAdminService
    {

        private UmbracoHelper _helper;

        public ContentAdminService(UmbracoHelper umbracoHelper)
        {
            _helper = umbracoHelper;
        }

        public List<PageViewModel> GetPageList()
        {
            var pages = new List<PageViewModel>();

            var root = _helper.ContentAtRoot().FirstOrDefault();

            if (root != null)
            {
                pages.Add(new PageViewModel(root.Id,root.Name, root.Url(null, UrlMode.Absolute)));
                TraversePageList(root, ref pages);
            }

            return pages;
        }

        private void TraversePageList(IPublishedContent node, ref List<PageViewModel> pages) {

            if (node.Children.Any()) {

                foreach (var item in node.Children)
                {
                    pages.Add(new PageViewModel(item.Id, item.Name, item.Url(null, UrlMode.Absolute)));
                    
                    TraversePageList(item, ref pages);
                }            
            }        
        }
    }
}
