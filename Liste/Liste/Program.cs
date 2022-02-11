using System;
using System.Collections.Generic;

//Codice di Login

namespace Liste
{

    public class Part : IEquatable<Part>
    {
        public string PartName { get; set; }

        public string Password { get; set; }

        public override string ToString()
        {
            return "ID: " + Password + "   Name: " + PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        /*public override int GetHashCode()
        {
            return PartId;
        }*/
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartName.Equals(other.PartName));
        }
        // Should also override == and != operators.
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of parts.
            List<Part> parts = new List<Part>();

            Console.WriteLine("Inserisci il nome utente");
            string nome1 = Console.ReadLine();

            // Add parts to the list.
            parts.Add(new Part() { PartName = "PippoInzaghi@gmail.com", Password = "Cinseino20" });
            parts.Add(new Part() { PartName = "chain ring", Password = "Cinseino20" });
            parts.Add(new Part() { PartName = "regular seat", Password = "Cinseino20" });
            parts.Add(new Part() { PartName = "banana seat", Password = "Cinseino20" });
            parts.Add(new Part() { PartName = "cassette", Password = "Cinseino20" });
            parts.Add(new Part() { PartName = "shift lever", Password = "Cinseino20" });

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\nContaiene(\"{0}\"): {1}", nome1,
       parts.Contains(new Part { PartName = nome1, Password = "Cinseino20" }));

            Console.ReadKey();
        }
    }
}
