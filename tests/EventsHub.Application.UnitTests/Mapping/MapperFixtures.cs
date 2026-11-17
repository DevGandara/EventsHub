using EventsHub.Application.Core.Mapping;

namespace EventsHub.Application.UnitTests.Mapping;

// Generic profiles are configured per test and excluded from assembly scanning.
public class TestProfile<TMarker> : Profile
{
    public TestProfile(Action<TestProfile<TMarker>> configure) => configure(this);

    public IMappingExpression<TSource, TDestination> Map<TSource, TDestination>()
        where TSource : class
        where TDestination : class => CreateMap<TSource, TDestination>();
}

public class Person
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string Secret { get; set; } = "";
    public string Nickname { get; set; } = "";
    public string ReadOnly { get; set; } = "";
}

public class PersonView
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string Secret { get; set; } = "original-secret";
    public string Label { get; set; } = "";
    public string Untouched { get; set; } = "keep";
    public string ReadOnly => "fixed";
}

public class PersonProfile : Profile
{
    public PersonProfile()
    {
        CreateMap<Person, PersonView>();
    }
}

public class Immutable(string name)
{
    public string Name { get; } = name;
}

public class Unrelated { }

public class ChildSource
{
    public string Name { get; set; } = "";
}

public class ChildDest
{
    public string Name { get; set; } = "";
}

public class ParentSource
{
    public ChildSource? Child { get; set; }
    public List<ChildSource> Items { get; set; } = [];
    public ChildSource[] Extras { get; set; } = [];
}

public class ParentDest
{
    public ChildDest? Child { get; set; }
    public List<ChildDest> Items { get; set; } = [];
    public IReadOnlyList<ChildDest> Extras { get; set; } = [];
}
