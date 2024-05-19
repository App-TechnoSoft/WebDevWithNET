public class Session
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string? Details { get; set; }
    public DateTime Start { get; set; }
    public float DurationInHours { get; set; }

    public int? CourseId { get; set; }
    public Course? Course { get; set; }
}


// Course has multiple sessions - one to many

// class A
// {    
// }

// class B
// {    
//     // A a1 = new();        // Tight coupling, hard coupling
//     // Dependency injection
//     // Most common: constructor injection
//     A a1;
//     public B(A a2)
//     {
//         a1 = a2;
//     }
// }
