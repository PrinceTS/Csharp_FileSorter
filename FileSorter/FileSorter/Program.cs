using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace FileSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Files fs = new Files();

            string basepath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(),@"../../../../../../"));
            Console.WriteLine("Add meg az elérési útvonalát a mappának");
            string path = Console.ReadLine();
            path = Path.GetFullPath(Path.Combine(basepath, path));
            string CurrentTime = DateTime.Now.ToString(@"-dd-MM-yyyy-(hh-mm-ss)");
            Directory.CreateDirectory(Path.GetFullPath(Path.Combine(path, CurrentTime)));
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                // Itt lehet bővíteni
                if(file.Contains(".mp4") || file.Contains(".mp3") || file.Contains(".wav")) fs.mediafajlok(path, CurrentTime);
                if (file.Contains(".png") || file.Contains(".jpg")) fs.kepek(path, CurrentTime);
                if (file.Contains(".pdf") || file.Contains(".docx") || file.Contains(".ppt") || file.Contains(".rtf")) fs.doksik(path, CurrentTime);
                if (file.Contains(".blend") || file.Contains(".blend1")) fs.blender(path, CurrentTime);
            }
        }
    }

    class Files
    {
        public void mediafajlok(string path, string CurrentTime)
        {
            string dirName = CurrentTime + "/mediafajlok";
            string path2 = Path.GetFullPath(Path.Combine(path, @dirName));
            try
            {
                if (Directory.Exists(path2))
                {
                    Console.WriteLine("A mappa már létezik ezen az útvonalon.");
                    return;
                }
                Directory.CreateDirectory(path2);
                Console.WriteLine("A mappa sikeresen létrehozva ekkor {0}.", Directory.GetCreationTime(path2));
            }
            catch (Exception e)
            {
                Console.WriteLine("A folyamat nem ment végbe: {0}", e.ToString());
            }
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (file.Contains(".mp4") || file.Contains(".mp3") || file.Contains(".wav"))
                {
                    string ideiglenesfajl;
                    string[] filesplitted = file.Split('\\');
                    ideiglenesfajl = filesplitted[filesplitted.Length - 1];
                    File.Move(Path.Combine(@path, @ideiglenesfajl), Path.Combine(@path2, @ideiglenesfajl));
                }
            }
        }

        public void kepek(string path, string CurrentTime)
        {
            string dirName = CurrentTime + "/kepek";
            string path2 = Path.GetFullPath(Path.Combine(path, @dirName));
            try
            {
                if (Directory.Exists(path2))
                {
                    Console.WriteLine("A mappa már létezik ezen az útvonalon.");
                    return;
                }
                Directory.CreateDirectory(path2);
                Console.WriteLine("A mappa sikeresen létrehozva ekkor {0}.", Directory.GetCreationTime(path2));
            }
            catch (Exception e)
            {
                Console.WriteLine("A folyamat nem ment végbe: {0}", e.ToString());
            }
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (file.Contains(".png") || file.Contains(".jpg"))
                {
                    string ideiglenesfajl;
                    string[] filesplitted = file.Split('\\');
                    ideiglenesfajl = filesplitted[filesplitted.Length - 1];
                    File.Move(Path.Combine(@path, @ideiglenesfajl), Path.Combine(@path2, @ideiglenesfajl));
                }
            }
        }

        public void doksik(string path, string CurrentTime)
        {
            string dirName = CurrentTime + "/doksik";
            string path2 = Path.GetFullPath(Path.Combine(path, @dirName));
            try
            {

                if (Directory.Exists(path2))
                {
                    Console.WriteLine("A mappa már létezik ezen az útvonalon.");
                    return;
                }
                Directory.CreateDirectory(path2);
                Console.WriteLine("A mappa sikeresen létrehozva ekkor {0}.", Directory.GetCreationTime(path2));
            }
            catch (Exception e)
            {
                Console.WriteLine("A folyamat nem ment végbe: {0}", e.ToString());
            }
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (file.Contains(".pdf") || file.Contains(".docx") || file.Contains(".ppt") || file.Contains(".rtf"))
                {
                    string ideiglenesfajl;
                    string[] filesplitted = file.Split('\\');
                    ideiglenesfajl = filesplitted[filesplitted.Length - 1];
                    File.Move(Path.Combine(@path, @ideiglenesfajl), Path.Combine(@path2, @ideiglenesfajl));
                }
            }
        }

        public void blender(string path, string CurrentTime)
        {
            string dirName = CurrentTime + "/blender";
            string path2 = Path.GetFullPath(Path.Combine(path, @dirName));
            try
            {

                if (Directory.Exists(path2))
                {
                    Console.WriteLine("A mappa már létezik ezen az útvonalon.");
                    return;
                }
                Directory.CreateDirectory(path2);
                Console.WriteLine("A mappa sikeresen létrehozva ekkor {0}.", Directory.GetCreationTime(path2));
            }
            catch (Exception e)
            {
                Console.WriteLine("A folyamat nem ment végbe: {0}", e.ToString());
            }
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (file.Contains(".blend") || file.Contains(".blend1"))
                {
                    string ideiglenesfajl;
                    string[] filesplitted = file.Split('\\');
                    ideiglenesfajl = filesplitted[filesplitted.Length - 1];
                    File.Move(Path.Combine(@path, @ideiglenesfajl), Path.Combine(@path2, @ideiglenesfajl));
                }
            }
        }



    }
}
