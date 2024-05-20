using HC_7710.Domain.Objects;

namespace HC_7710.GraphQL.Queries;

[ExtendObjectType(OperationTypeNames.Query)]
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