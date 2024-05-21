using System;

public class Entry
{
    public int _entryId;
    public string _entryContent;
    public DateTime _date;

    public Entry(int entryId, string entryContent)
    {
        _entryId = entryId;
        _entryContent = entryContent;
        _date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Entry ID {_entryId} - {_date.ToShortDateString()}: {_entryContent}";
    }
}
