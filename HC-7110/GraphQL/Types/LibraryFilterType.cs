using HC_7710.Domain.Objects;
using HotChocolate.Data.Filters;

namespace HC_7710.GraphQL.Types;

public class LibraryFilterType : FilterInputType<Library>
{
    protected override void Configure(IFilterInputTypeDescriptor<Library> descriptor)
    {
        descriptor
            .Field(p => p.Id)
            .Type<IdOperationFilterInputType>();
    }
}