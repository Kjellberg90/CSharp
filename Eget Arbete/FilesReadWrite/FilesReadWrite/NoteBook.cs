using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesReadWrite
{
    class NoteBook
    {
        public void TakeNote(string myString)
        {
            if (!File.Exists("notes.txt"))
            {
                File.WriteAllText("Notes.txt", $"{"Note",-20}Date \n---------------------------------------");
                string text = $"\n{myString,-20}{DateTime.Now.ToString()}";
                File.AppendAllText("notes.txt", text);
            }
            else
            {
                string text = $"\n{myString,-20}{DateTime.Now.ToString()}";
                File.AppendAllText("notes.txt", text);
            }
        }

        public string[] GetAllNotes()
        {
            string[] notes = File.ReadAllLines("notes.txt");
            string[] notesArray = new string[notes.Length] ;
            
            for (int i = 2; i < notes.Length; i++)
            {
                notesArray[i] = notes[i];
                Console.WriteLine(notesArray[i]);
            }
            return notesArray;
        }
    }
}
