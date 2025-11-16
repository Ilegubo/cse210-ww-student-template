namespace journal_project;
using System;
using System.Collections.Generic;
using System.IO;

public class loadAndSave
{
    public string _fileName, _content;
    public List<string> _notes = new List<string>();
    
    

    public bool loadJournal(string _fileName)
    {
        try
        {
            string[] lines = File.ReadAllLines(_fileName);
            foreach (string line in lines)
            {
                _notes.Add(line);
            }

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occured while loading file {e}");
            return false ;
        }
        
         
    }

    public bool saveJournal(string _fileName)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                outputFile.WriteLine(_notes);
                Console.WriteLine("File saved successfully");
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occured while saving file {e}");
            return false;

        }
    }
    
    
}