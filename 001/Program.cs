namespace _001;

public class ProjectTask
{
    public readonly string Title;
    public readonly int DaysAllocated;
    public readonly bool IsCompleted;

    public ProjectTask(
        string _Title,
        int _DaysAllocated,
        bool _IsCompleted
    )
    {
        Title = _Title;
        DaysAllocated = _DaysAllocated;
        IsCompleted = _IsCompleted;
    }

    public void PrintStatus()
    {
        Console.Write(Title);
        if(IsCompleted)
        {
            Console.WriteLine(" [DONE: Completed.]");
        } else if (DaysAllocated <= 7)
        {
            Console.WriteLine(" [PENDENT: On Schedule.]");
        } else
        {
            Console.WriteLine(" [CRITICAL: Needs Attention!]");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var myTask = new ProjectTask(
            "Develope a new feature for collections input based filtering.",
            8,
            false
        );

        myTask.PrintStatus();
        Console.ReadLine();
    }
}
