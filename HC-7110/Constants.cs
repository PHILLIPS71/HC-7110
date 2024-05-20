using HC_7710.Domain.Objects;

namespace HC_7710;

public class Constants
{
    public static ICollection<Library> Libraries = new List<Library>
    {
        new()
        {
            Id = Guid.NewGuid(),
            Name = "The Simpsons",
            Slug = "the-simpsons"
        },
        new()
        {
            Id = Guid.NewGuid(),
            Name = "Family Guy",
            Slug = "family-guy"
        }
    };
}