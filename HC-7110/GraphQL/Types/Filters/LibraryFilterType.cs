using HC_7110.Domain.Objects;
using HotChocolate.Data.Filters;

namespace HC_7110.GraphQL.Types.Filters;

public class LibraryFilterType : FilterInputType<Library>
{
    protected override void Configure(IFilterInputTypeDescriptor<Library> descriptor)
    {
        descriptor
            .Field(p => p.Id)
            .Type<IdOperationFilterInputType>();
    }
}