// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace journal_project;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Project");

        string Menu()
        {
            Console.WriteLine("Please select from the menu.");
            //Menu
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("option: ");
            string option = Console.ReadLine();

            return option;
        }

        WriteAndDisplay wad = new WriteAndDisplay();
        loadAndSave las = new loadAndSave();
        while (true)
        {
            string option = Menu();
            if (option == "1") //write
            {
                string _prompt = wad.selectPrompt();
                Console.WriteLine(_prompt);
                wad._note = Console.ReadLine();
                wad.writeJournal(_prompt);
            }

            else if (option == "2") //display
            {
                if (wad._notes == null || wad._notes.Count == 0)
                {
                    if (las._notes == null || las._notes.Count == 0)
                    {
                        Console.WriteLine("No entries found.");
                    }

                    else
                    {
                        wad.displayJournal(las._notes);
                    }
                }

                else
                {
                    wad.displayJournal(wad._notes);
                }
            }
            
            else if (option == "3") //load file
            {
                
                try
                {
                    Console.Write("Enter file name: ");
                    las._fileName = Console.ReadLine().ToLower();
                    string[] lines = File.ReadAllLines(las._fileName);
                    foreach (string line in lines)
                    {
                        wad._notes.Add(line);
                    }

                    las._notes = wad._notes;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An error occured while loading {e}");
                }
            }
            
            else if (option == "4") //save
            {
                Console.Write("File name: ");
                las._fileName = Console.ReadLine();
                
                using (StreamWriter outputFile = new StreamWriter(las._fileName))
                    try
                    {
                        foreach (string line in wad._notes)
                        {
                            outputFile.WriteLine(line);
                        }
                    }
                    catch (FileNotFoundException fnfe)
                    {
                        Console.WriteLine($"File Not found!! {fnfe.Message}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"An error occurred while loading file.");
                    }
            }
            
            else if (option == "5")
            {
                Console.WriteLine("Exiting...");
                return;
            }
        }
    }
}

