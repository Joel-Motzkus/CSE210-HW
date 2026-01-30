using System;


class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);

        foreach (Entry entry in _entries)
        {
            writer.WriteLine(entry.ToFileString());
        }

        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        foreach (string line in File.ReadAllLines(filename))
        {
            _entries.Add(Entry.FromFileString(line));
        }

        Console.WriteLine("Journal loaded.");
    }
}