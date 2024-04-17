using System;

class Program
{
    static void Main(string[] args)
    {
        string palabra = "Otoniel";
        ImprimirCombinaciones(palabra);
    }

    static void ImprimirCombinaciones(string palabra)
    {
        ImprimirCombinacionesAuxiliar("", palabra);
    }

    static void ImprimirCombinacionesAuxiliar(string prefijo, string sufijo)
    {
        int n = sufijo.Length;
        if (n == 0)
        {
            Console.WriteLine(prefijo);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                ImprimirCombinacionesAuxiliar(prefijo + sufijo[i], sufijo.Substring(0, i) + sufijo.Substring(i + 1, n - i - 1));
            }
        }
    }
}
