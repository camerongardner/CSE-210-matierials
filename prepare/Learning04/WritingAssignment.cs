public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string title) : base(studentName, "Writing")
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_studentName}{_topic}\n{_title}";
    }
}