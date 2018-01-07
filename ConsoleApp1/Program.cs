using System;
using System.Collections.Generic;

namespace Persons

{
    class Program
    { 
        static void Main(string[] args)
        {
            List<NewPerson> ljudi = new List<NewPerson>();
            while (true)
            {
                Console.WriteLine("Uneti komandu");
                String command = Console.ReadLine();

                if (command == "nova")
                {
                    Console.WriteLine("Uneti ime, prezime i godine sa zarezom");

                    string[] vrednosti = Console.ReadLine().Split(',');
                    NewPerson newPerson = new NewPerson(int.Parse(vrednosti[2]), vrednosti[0], vrednosti[1], Guid.NewGuid().ToString());
                    Console.WriteLine("Uneta osoba:" + newPerson.FullName + "," + newPerson.Age + ";" + newPerson.Id);
                    ljudi.Add(newPerson);
                }

                else if (command == "izlistaj")
                {
                    for (int i = 0; i < ljudi.Count; i++)
                    {
                        Console.WriteLine("Full name: " + ljudi[i].FullName + " Age: " + ljudi[i].Age + "  ID:" + ljudi[i].Id);
                    }

                }

                else if (command == "prezime")
                {
                    Console.WriteLine("izabrati osobu po id-ju");
                    string izabranId = Console.ReadLine();

                    Console.WriteLine("izabrati novo prezime");
                    string novoPrezime = Console.ReadLine();

                    for (int i = 0; i < ljudi.Count; i++)
                    {
                        if (ljudi[i].Id.Equals(izabranId))
                        {
                            ljudi[i].PromenaPrezimena(novoPrezime);

                        }

                    }

                }

                else if (command == "ostari")
                {
                    Console.WriteLine("izabrati osobu po id-ju");
                    string izabranId = Console.ReadLine();
                    for (int i = 0; i < ljudi.Count; i++) {
                        if (ljudi[i].Id.Equals(izabranId))
                        Console.WriteLine("Izabrati koliko godina ce ostariti " + ljudi[i].FullName); }
                    int brojGodina = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < ljudi.Count; i++)
                    {
                        if (ljudi[i].Id.Equals(izabranId))
                        {
                            ljudi[i].PromenaGodina(brojGodina);

                        }

                    }

                }


            }
        }
       
    }
}
