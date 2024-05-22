using HC_7110.Domain.Objects;

namespace HC_7110.GraphQL.Types.Objects;

[ObjectType<Library>]
public static partial class LibraryType
{
    static partial void Configure(IObjectTypeDescriptor<Library> descriptor)
    {
        descriptor
            .ImplementsNode()
            .IdField(p => p.Id);
    }

    [NodeResolver]
    internal static Library? GetLibraryById(Guid id, CancellationToken cancellation)
    {
        return Constants.Libraries.SingleOrDefault(x => x.Id == id);
    }
}