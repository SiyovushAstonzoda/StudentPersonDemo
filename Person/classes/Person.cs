namespace classes;
public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }

    public string? GetName()
    {
        return $"{FirstName} {LastName}";
    }
    public int GetYear()
    {
        return 2023 - Age;
    }
}
