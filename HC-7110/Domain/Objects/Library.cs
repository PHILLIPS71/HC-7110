namespace HC_7710.Domain.Objects;

public class Library
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;
}