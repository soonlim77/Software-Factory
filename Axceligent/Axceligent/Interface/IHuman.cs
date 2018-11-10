namespace Axceligent.Interface
{
    public interface IHuman
    {
        int Age { get; set; }
        string FirstName { get; set; }
        GenderType Gender { get; set; }
        string LastName { get; set; }
    }

    public enum GenderType
    {
        male,
        female
    }
}