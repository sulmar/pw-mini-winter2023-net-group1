namespace Domain.Model;


public abstract class Base
{
   
}

public abstract class BaseEntity : Base
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public Gender Gender { get; set; }
}

public enum Gender
{
    Male,
    Female
}

public class Issue : BaseEntity
{

    
}
