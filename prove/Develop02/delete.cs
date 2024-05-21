public class Delete
{
    public static void DeleteEntry(Journal journal, int id)
    {
        var entry = journal.ListEntries().FirstOrDefault(e => e._entryId == id);
        if (entry != null)
        {
            journal.RemoveEntry(entry);
            Console.WriteLine("Entry removed successfully");
        }
        else
        {
            Console.WriteLine("Entry not found");
        }
    }
}