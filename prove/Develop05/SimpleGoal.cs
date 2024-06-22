using System;

public class SimpleGoal : NewGoal
{
    public override void Create(string filename)
    {
        _DefaultFileName = filename;
        Start();
        SaveToCSV();
    }
}
