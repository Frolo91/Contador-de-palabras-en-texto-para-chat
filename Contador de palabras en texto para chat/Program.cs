

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPalabras = 0, numLetra = 0;
            char[] linea;
            bool bandera;
            String letra ;
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\Frolo\Desktop\prueba.txt"); // Solo se debe cambiar la ruta donde esta el texto
            Console.WriteLine("Letra a verificasr la cantidad: ");
            letra = Console.ReadLine(); // se carga el texto txt
            for (int i = 0; i < text.Length; i++)
            {
                bandera = true;
                linea = text[i].ToCharArray(); // Corta las palabras de forma automatica
                for (int j = 0; j < linea.Length; j++)
                {
                    if (linea[j] == letra[0]) // me cuenta las letras
                    {
                        numLetra++;
                    }
                    if (linea[j] != ' ' && bandera)
                    {
                        bandera = false;
                        numPalabras++;
                    }
                    else
                    {
                        if (linea[j] == ' ')
                        {
                            bandera = true;
                        }
                    }
                }
                Console.WriteLine("Numero de palabras: " + numPalabras);
                Console.WriteLine("La letra '" + letra + "' se repite " + numLetra + " veces");
                // EJEMPLO DE string.ToCharArray()
                //|string s = "string";
                //|Console.WriteLine(s[1]); // returns t
                //|char[] chars = s.ToCharArray();
                //|Console.WriteLine(chars[1]); // tambien returns t
            }
        }
    }
}