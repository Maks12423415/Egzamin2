class Tablica
{
    private int[] tab;
    private int liczba_elementow;

    public Tablica( int liczba_elementow)
    {
        Random random = new Random();
        tab = new int[ liczba_elementow ];
        this.liczba_elementow = liczba_elementow;
        for (int i = 0; i < liczba_elementow; i++)
        {
            tab[i] = random.Next(1,1001);
        }
    }
    /*
    **********************************************
    nazwa metody: Wyswietl
    opis metody: Wyświetla wszytskie liczby w tabeli
    parametry: brak

    zwracany typ i opis: brak
    autor: 00000000000
    ***********************************************
    */
    void Wyswietl()
    {
        for(int i = 0; i  < liczba_elementow ; i++)
        {
            Console.WriteLine(i + ": " + tab[i]);
        }
    }

    /*
   **********************************************
   nazwa metody: Wyszukaj
   opis metody: Wyszukuje podaną liczbe w tabeli
   parametry: szukana - liczba szukana w tabeli

   zwracany typ i opis: index - index szukanej liczby
   autor: 00000000000
   ***********************************************
   */
    int Wyszukaj(int szukana)
    {
        int index = -1;
        for (int i = 0;i < liczba_elementow; i++)
        {
            if(szukana == tab[i])
            {
                Console.WriteLine("Indeks: " + i);
                index = i;
            }  
        }
        return index;
    }
    /*
   **********************************************
   nazwa metody: Nieparzyste
   opis metody: wypisuje wsyztskie liczby nieparzyste
   parametry: brak

   zwracany typ i opis: nieparzyste - liczba liczb nieparzystych
   autor: 00000000000
   ***********************************************
   */
    int Nieparzyste()
    {
        int nieparzyste = 0;
        Console.WriteLine("Liczby nieparzyste: ");
        for( int i = 0;i < liczba_elementow ; i++)
        {
            if (tab[i] % 2 == 0)
            {

            }
            else
            {
                nieparzyste++;
                Console.WriteLine(tab[i]);
            }
        }
        Console.WriteLine("Razem nieparzystych: "+ nieparzyste);
        return nieparzyste;
    }
    /*
   **********************************************
   nazwa metody: Srednia
   opis metody: obliczba średnia liczb w tabeli
   parametry: brak

   zwracany typ i opis: srednia = średnia wszytski liczb w tabeli
   autor: 00000000000
   ***********************************************
   */
    double Srednia()
    {
        double srednia = 0;
        int suma = 0;

        for(int i = 0; i < liczba_elementow; i++)
        {
            suma += tab[i];
        }
        srednia = suma / liczba_elementow; 
        Console.Write("Średnia wszytskich elementów: "+ srednia);
        return srednia;
    }


    class Program
    {
        static void Main()
        {
            Tablica tablica = new Tablica(50);

            tablica.Wyswietl();
            tablica.Wyszukaj(123);
            tablica.Nieparzyste();
            tablica.Srednia();
    
    }

    }

}
