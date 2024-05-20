using HC_7710.Domain.Objects;
using HC_7710.Persistence;

namespace HC_7710.GraphQL.Queries;

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