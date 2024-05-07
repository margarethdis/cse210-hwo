public class Resume
{
    public string _name;
    public List<Job> _jobs= new List<Job>();


//se puede usar esta funciondisplay siempre para desplegar un mensaje?
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        foreach( Job job  in _jobs)
        {
            job.Display();
        }
    }
}