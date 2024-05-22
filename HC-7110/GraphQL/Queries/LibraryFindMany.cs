using HC_7110.Domain.Objects;

namespace HC_7110.GraphQL.Queries;

[QueryType]
public class LibraryFindMany
{
    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Library> Libraries()
    {
        return Constants.Libraries.AsQueryable();
    }
}