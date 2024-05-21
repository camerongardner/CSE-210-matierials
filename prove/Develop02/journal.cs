using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    public List<Entry> _entries;
    public string _title;
    public DateTime _date;
    private int _nextEntryId;  // Maintain a separate ID counter for unique IDs

    public Journal(string title)
    {
        _entries = new List<Entry>();
        _title = title;
        _date = DateTime.Now;
        _nextEntryId = 1;  // Start IDs from 1
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        SaveEntries();
    }


    public void RemoveEntry(Entry entry)
    {
        _entries.Remove(entry);
        SaveEntries();
        LoadEntries();
    }

    public List<Entry> ListEntries()
    {
        return _entries;
    }

    public int GetNextEntryId()
    {
        return _nextEntryId++;  // Increment and return the next ID
    }

    private void SaveEntries(bool setZero = false)
    {
        using (StreamWriter file = new StreamWriter("journal.csv", false))  // Ensure overwrite mode, not append mode
        {

            _nextEntryId = 1;
            file.WriteLine("EntryID,Content,Date");  // Write the header
            foreach (Entry entry in _entries)
            {
                file.WriteLine($"{_nextEntryId},{entry._entryContent},{entry._date:yyyy-MM-dd HH:mm:ss}");
            }
        }
    }


    public void LoadEntries()
    {
        _entries = new List<Entry>();
        string filePath = "journal.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 1)
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 3)
                    {
                        string content = parts[1];
                        DateTime date = DateTime.Parse(parts[2]);

                        //Use the _nextEntryId of the journal to keep count
                        _entries.Add(new Entry(_nextEntryId, content) { _date = date });
                        ++_nextEntryId; // After creating an entry, increment the ID count
                        
                    }
                }
            }
        }
        else
        {
            File.Create(filePath).Close();  // Create the file if it does not exist and close it immediately
            Console.WriteLine("No existing journal found. A new journal has been created.");
            // Optionally write the header to the new file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("EntryID,Content,Date");
            }
        }
    }
}
