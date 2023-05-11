using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Learning.Site.Services;

public class SearchService : ISearchService
{
    public IEnumerable<IPublishedContent> QueryUmbraco(string searchTerm, IPublishedContent context)
    {
        var res = context.Root().Children.Where(x => x is NewsArticle).ToList();

        return res;
    }
}

public interface ISearchService
{
    IEnumerable<IPublishedContent> QueryUmbraco(string searchTerm, IPublishedContent context);
}
