using HC_7710.Domain.Objects;
using HC_7710.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HC_7710.GraphQL.Types.Objects;

[ObjectType<Library>]
public static partial class LibraryType
{
    static partial void Configure(IObjectTypeDescriptor<Library> descriptor)
    {
        descriptor
            .ImplementsNode()
            .IdField(p => p.Id);
        
        descriptor
            .Field(p => p.Id);
    }

    [NodeResolver]
    internal static Task<Library?> GetLibraryById(
        Guid id,
        ApplicationDbContext database,
        CancellationToken cancellation)
    {
        return database.Libraries.SingleOrDefaultAsync(x => x.Id == id, cancellation);
    }
}