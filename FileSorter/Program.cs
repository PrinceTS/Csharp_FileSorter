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

            Console.WriteLine("Válasz meghajtót! (Csak a betűjele)");
            string disk = Console.ReadLine();
            string basepath = disk + ":/";
            Console.WriteLine("Add meg az elérési útvonalát a mappának");
            string path = Console.ReadLine();
            path = Path.GetFullPath(Path.Combine(basepath, path));
            string CurrentTime = DateTime.Now.ToString(@"-dd-MM-yyyy-(hh-mm-ss)");
            Directory.CreateDirectory(Path.GetFullPath(Path.Combine(path, CurrentTime)));
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                
                // Itt lehet bővíteni
                if(file.Contains(".mp4") || file.Contains(".mp3") || file.Contains(".wav") || file.Contains(".avi") || file.Contains(".flv") || file.Contains(".mov") || file.Contains(".mpeg") || file.Contains(".wmv")) fs.mediafajlok(path, CurrentTime);
                if(file.Contains(".png") || file.Contains(".jpg") || file.Contains(".jpeg") || file.Contains(".gif") || file.Contains(".bmp") || file.Contains(".tiff") || file.Contains(".webp")) fs.kepek(path, CurrentTime);
                if(file.Contains(".txt") || file.Contains(".pdf") || file.Contains(".docx") || file.Contains(".ppt") || file.Contains(".pptx") || file.Contains(".rtf") || file.Contains(".tex") || file.Contains(".odt") || file.Contains(".xml") || file.Contains(".doc")) fs.doksik(path, CurrentTime);
                if(file.Contains(".blend") || file.Contains(".blend1") || file.Contains(".mdl") || file.Contains(".fbx") || file.Contains(".obj")) fs.blender(path, CurrentTime);
                if (file.Contains(".torrent")) fs.Torrent(path, CurrentTime);
                if (file.Contains(".py")) fs.Python(path, CurrentTime);
                if (file.Contains(".exe")) fs.programok(path, CurrentTime);
                if (file.Contains(".zip") || file.Contains(".rar") || file.Contains(".iso")) fs.Csomagolt(path, CurrentTime);
                if (file.Contains(".pkt") || file.Contains(".pka")) fs.Network(path, CurrentTime); 
                
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
                if (file.Contains(".mp4") || file.Contains(".mp3") || file.Contains(".wav") || file.Contains(".avi") || file.Contains(".flv") || file.Contains(".mov") || file.Contains(".mpeg") || file.Contains(".wmv"))
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
                if (file.Contains(".png") || file.Contains(".jpg") || file.Contains(".jpeg") || file.Contains(".gif") || file.Contains(".bmp") || file.Contains(".tiff") || file.Contains(".webp"))
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
                if (file.Contains(".txt") || file.Contains(".pdf") || file.Contains(".docx") || file.Contains(".ppt") || file.Contains(".pptx") || file.Contains(".rtf") || file.Contains(".tex") || file.Contains(".odt") || file.Contains(".xml") || file.Contains(".doc"))
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
                if (file.Contains(".blend") || file.Contains(".blend1") || file.Contains(".mdl") || file.Contains(".fbx") || file.Contains(".obj"))
                {
                    string ideiglenesfajl;
                    string[] filesplitted = file.Split('\\');
                    ideiglenesfajl = filesplitted[filesplitted.Length - 1];
                    File.Move(Path.Combine(@path, @ideiglenesfajl), Path.Combine(@path2, @ideiglenesfajl));
                }
            }
        }

        public void Torrent(string path, string CurrentTime)
        {
            string dirName = CurrentTime + "/Torrent";
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
                if (file.Contains(".torrent"))
                {
                    string ideiglenesfajl;
                    string[] filesplitted = file.Split('\\');
                    ideiglenesfajl = filesplitted[filesplitted.Length - 1];
                    File.Move(Path.Combine(@path, @ideiglenesfajl), Path.Combine(@path2, @ideiglenesfajl));
                }
            }
        }
        public void Csomagolt(string path, string CurrentTime)
        {
            string dirName = CurrentTime + "/csomagolt";
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
                if (file.Contains(".zip") || file.Contains(".rar") || file.Contains(".iso"))
                {
                    string ideiglenesfajl;
                    string[] filesplitted = file.Split('\\');
                    ideiglenesfajl = filesplitted[filesplitted.Length - 1];
                    File.Move(Path.Combine(@path, @ideiglenesfajl), Path.Combine(@path2, @ideiglenesfajl));
                }
            }
        }

        public void programok(string path, string CurrentTime)
        {
            string dirName = CurrentTime + "/programok";
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
                if (file.Contains(".exe"))
                {
                    string ideiglenesfajl;
                    string[] filesplitted = file.Split('\\');
                    ideiglenesfajl = filesplitted[filesplitted.Length - 1];
                    File.Move(Path.Combine(@path, @ideiglenesfajl), Path.Combine(@path2, @ideiglenesfajl));
                }
            }
        }

        public void Python(string path, string CurrentTime)
        {
            string dirName = CurrentTime + "/Python";
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
                if (file.Contains(".py"))
                {
                    string ideiglenesfajl;
                    string[] filesplitted = file.Split('\\');
                    ideiglenesfajl = filesplitted[filesplitted.Length - 1];
                    File.Move(Path.Combine(@path, @ideiglenesfajl), Path.Combine(@path2, @ideiglenesfajl));
                }
            }
        }

        public void Network(string path, string CurrentTime)
        {
            string dirName = CurrentTime + "/Network";
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
                if (file.Contains(".pkt") || file.Contains(".pka"))
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
