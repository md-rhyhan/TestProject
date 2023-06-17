namespace TestProject.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = string.Empty;
    public string? Phone { get; set; }


    public static List<Student> GetAllStudent()
    {
        int id = 1;

        return new List<Student>()
        {
            new() { Id = id++, Name = "Hasan", Email="hasan@gmail.com", Phone="31212121212112" },
            new() { Id = id++, Name = "wrewer", Email="hasan@gmail.com", Phone="31212121212112" },
            new() { Id = id++, Name = "werwer", Email="hasan@gmail.com", Phone="31212121212112" },
            new() { Id = id++, Name = "dgdfg", Email="hasan@gmail.com", Phone="31212121212112" },
            new() { Id = id++, Name = "rerr", Email="hasan@gmail.com", Phone="31212121212112" },
            new() { Id = id++, Name = "gghfgh", Email="hasan@gmail.com", Phone="31212121212112" },
            new() { Id = id++, Name = "fcvbcb", Email="hasan@gmail.com", Phone="31212121212112" },
            new() { Id = id++, Name = "Hasan", Email="hasan@gmail.com", Phone="31212121212112" },
            new() { Id = id++, Name = "dgdgd", Email="hasan@gmail.com", Phone="31212121212112" },
        };
    }
}


