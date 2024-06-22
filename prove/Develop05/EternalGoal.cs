using System;

public class EternalGoal : NewGoal
{
    public override void Create(string filename)
    {
        _DefaultFileName = filename;
        Start();
        _isEternal = 1;
        SaveToCSV();
    }
}