using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileInfoMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\users\minat\siralama.txt";

            /*
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (FileStream fs = File.Create(fileName))
                {
                    byte[] title = new UTF8Encoding(true).GetBytes("siralama odevi\n");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("Mina Turgut\n");
                    fs.Write(author, 0, author.Length);
                    byte[] body = new UTF8Encoding(true).GetBytes("There are many variations of passages " +
                        "of Lorem Ipsum available, but the majority have suffered alteration in some " +
                        "form, by injected humour, or randomised words which don't look even slightly " +
                        "believable. If you are going to use a passage of Lorem Ipsum, you need to be sure " +
                        "there isn't anything embarrassing hidden in the middle of text. All the Lorem " +
                        "Ipsum generators on the Internet tend to repeat predefined chunks as necessary, " +
                        "making this the first true generator on the Internet. It uses a dictionary of over " +
                        "200 Latin words, combined with a handful of model sentence structures, to generate " +
                        "Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always " +
                        "free from repetition, injected humour, or non-characteristic words etc.");
                    fs.Write(body, 0, body.Length);
                }

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            */

            string text = File.ReadAllText(fileName);
            char[] sil = { ' ', ',', '.', ':', '\t', '\n' };
            string[] words = text.Split(sil, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            Array.Reverse(words);
            List<string> fazlaliklar = words.Distinct().ToList();
           
            foreach (var word in fazlaliklar)
            {
                Console.Write("{0}\n", word.ToString());
            }
            Console.ReadKey();
        }
    }
}
