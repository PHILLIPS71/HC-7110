using HC_7110.Domain.Objects;

namespace HC_7110.GraphQL.Queries;

[QueryType]
public class LibraryFindOne
{
    [UseFirstOrDefault]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Library> Library()
    {
        return Constants.Libraries.AsQueryable();
    }
}