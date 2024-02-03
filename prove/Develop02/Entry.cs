using System;
using System.IO;
public class Entry
{
    public string _prompt;
    public string _response;
    public DateTime _entryDate;


    public static void SaveToFile(List<Entry> entries)
    {
        string fileName = "entries.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
           foreach (Entry e in entries)
           {
                outputFile.WriteLine($"{e._prompt} \n {e._response} \n {e._entryDate}");
           } 
        }
        Console.WriteLine($"Entries saved to {fileName}");
    }




}