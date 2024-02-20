using Umbraco.Cms.Web.BackOffice.Trees;

namespace KnowledgeWork.FAFO.Models
{
    public class PageViewModel
    {
        public PageViewModel() { }
        public PageViewModel(int id, string name, string url)
        {
            this.Id = id;
            this.Name = name;
            this.Url = url;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
