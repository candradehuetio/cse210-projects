using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    /////// Member variables//////////
    public List<Entry> _entries = new List<Entry>();


    /// Journal methods
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry p in _entries)
            {
                outputFile.WriteLine($"{p._date}$${p._promptText}$${p._entryText}");
            }
        }
    }


    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            // splittin each line in csv by every "$$" caracter
            string[] parts = line.Split("$$");

            /// Date -- 0
            /// Prompt -- 1
            /// Entry -- 2

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }
}