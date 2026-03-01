public class Student
{

    public string Name { get; set; }
    public int Id { get; set; }

    public Student(string name, int id)
    {
        Name = name;
        Id = id;
    }

    
   public void DisplayInfo()
    {
        Console.WriteLine($"Student Name: {Name}, ID: {Id}");
    }
}