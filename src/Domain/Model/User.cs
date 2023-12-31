namespace Domain.Model;

public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";

    public bool IsAdmin { get; set; }   
    public Gender Gender { get; set; }
}

public enum Gender
{
    Male,
    Female
}