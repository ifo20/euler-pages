namespace EulerPages.Models
{
    public interface IProblem
    {
        int Id { get; set; }
        string Title { get; set; }
        string Question { get; set; }
        bool Solved { get; set; }
        int Answer { get; set; }
        string Solution { get; set; }
    }
}