namespace TestingTechniques;

public class ValueSamples
{
    public string FullName = "Orima Salimi";

    public int Age = 27;

    public DateOnly DateOfBirth = new (1998, 1, 28);

    public User AppUser = new()
    {
        FullName = "Orima Salimi",
        Age = 27,
        DateOfBirth = new (1998, 1, 28)
    };

    public IEnumerable<User> Users = new[]
    {
        new User()
        {
            FullName = "Orima salimi",
            Age = 27,
            DateOfBirth = new (1998, 1, 28)
        },
        new User()
        {
            FullName = "Sepehr HatamRavesh",
            Age = 37,
            DateOfBirth = new (1984, 6, 9)
        },
        new User()
        {
            FullName = "Ali soltani",
            Age = 43,
            DateOfBirth = new (1978, 10, 5)
        }
    };

    public IEnumerable<int> Numbers = new[] { 1, 5, 10, 15 };

    public event EventHandler ExampleEvent;

    internal int InternalSecretNumber = 42;

    public virtual void RaiseExampleEvent()
    {
        ExampleEvent(this, EventArgs.Empty);
    }
}
