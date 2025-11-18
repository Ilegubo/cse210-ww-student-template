using System.Security.Cryptography.X509Certificates;

namespace journal_project;

public class WriteAndDisplay
{
    public string _content, _note;
    // string _note is the note the user wants to enter
    //List<string> _notes are the compliation of 
    public List<string> _notes = new List<string>();
    public List<string> _prompts = new List<string>();
    public int length;

    public void WriteJournal(string _prompt)
    {
        
        string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        length = $"{date}".Length;
        string spaces = new string(' ',length);
        _content = $"{date}    {_prompt}\n{spaces}    {_note}\n";
        _notes.Add(_content);
    }

    public void DisplayJournal(List<string> _notes)
    {
        foreach (string _journalEntry in _notes)
        {
            Console.WriteLine(_journalEntry);
        }
    }
    
    public void AddPrompts()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would that be?");
        _prompts.Add("What about today would you like to improve upon next time?");

    }

    public string selectPrompt()
    {
        AddPrompts();
        Random rnd = new Random();

        public int _rndPrompt = rnd.Next(0, _prompts.Count);
        return _prompts[_rndPrompt];
    }
}

