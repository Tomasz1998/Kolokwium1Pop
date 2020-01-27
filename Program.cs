using System;

namespace KolokwiumPoprawa
{
    class Program
    {
        /* 1. Napisz funkcje, która przyjmuje współrzedne X i Y punktu z przedziału [-1,1]. Funkcja powinna zwrócić
         * wartość true jeśli punkt należy do koła o promieniu 1 i środku w okręgu [0,0] lub false 
         * w przeciwnym wypadku wczytaj dane od użytkownika i przetestuj funkcje | a^2+b^2 <=1 
           2. Napisz funkcje która znajdzie w tablicy jednowymiarowej int najszczęsciej występujący element. 
           Stwórz 10-elm. tablice uzupełnij przykładowymi danymi i wykonaj funkcje.
           3. Napisz funkcje która przyjmie kwadratową, dwuwymiarową tablice int i wypisze informacje, czy suma elementów ponad przekątna tablicy jest równa 
           sumie elementów pod przekątna tablicy. Wypełnij tablice np ze wzoru i+j. Wykonaj funkcje, Wprowadź dowolną zmiane w tablicy. Wykonaj funkcje ponownie. Przekątna [0,0] > [n,n]
           elementów przekątnej nie wyliczamy
           4. Stwórz klase KontoBankowe. By utworzyć konto nalezy podaj imie i nazwisko właściciela. Podczas tworzenia konta wygeneruj numer składający się z 26 cyfr
           Dane właściciela nie mogą być zmieniane - utwórz odpowiednie zabezpieczenie. Konto musi posiadać pole stan. Stan moze być zmieniany wyłącznie za pomocą metod Uznanie i obcienie.
           Utwórz zaezpieczenie które nie pozwoli na debet większy niż 100zł. Stwórz kolekcje liczb historia, w której zapisane będą kwoty ostatnich 100 operacji
           dodatnie lub ujemne. Jeśli wykonane będzie ponad 100 operacji, nadpisz starsze wpisy
           5. Napisz funkcje która przyjmie dwuwymiarową tablice double i usunie z niej wybrany wiersz lub kolumne.
           Funkcja powinna przyjmować tablice, indekt numerowany od zera a także wartość bool - true jeśli usuwamy kolumne, false jeśli wiersz. Funkcja powinna
           zwracać pomniejszą tablice z przepisanymi pozostałymi wartościami. Stwórz przykładową tablice 3x3, wypełnij danymi i usuń środkowy wiersz i pierwsza kolumne*/
        public static void Zadanie1()
        {
            Console.WriteLine("Podaj x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y");
            double y = double.Parse(Console.ReadLine());
            if ((x * x) + (y * y) <= 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public static void Zadanie2()
        {
            int[] tab = new int[10];

            tab[0] = 1;
            tab[1] = 2;
            tab[2] = 2;
            tab[3] = 7;
            tab[4] = 4;
            tab[5] = 1;
            tab[6] = 2;
            tab[7] = 1;
            tab[8] = 14;
            tab[9] = 1;

            int wynik = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                if (tab[i] == 1)
                {
                    wynik += 1;
                }
            }
            Console.WriteLine("najwięcej wystąpiło " + wynik + " elementy o wartości 1"); ;

        }
        public static void Zadanie3()
        {

            int[,] tab1 = new int[5, 5];


            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = i + j;
                }
            }
            tab1[3, 4] = 55;
            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    Console.Write(" " + tab1[i, j]);
                }
                Console.WriteLine();
            }
            int suma = 0;
            int suma1 = 0;
            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    if (i + 1 > j)
                    {
                        continue;
                    }
                    else
                    {
                        suma += tab1[i, j];
                    }
                }
            }
            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    if (i < j + 1)
                    {
                        continue;
                    }
                    else
                    {
                        suma1 += tab1[i, j];
                    }
                }
            }

            if (suma == suma1)
            {
                Console.WriteLine("sumy pod i nad przekątną są równe");
            }
            else
            {
                Console.WriteLine("sumy pod i nad przekątna nie są równe");
            }
        }
        public static void WypiszTablice(double[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write($"\t{tab[i, j]}");
                }
                Console.WriteLine();
            }
        }
        public static double[,] Zadanie5(double[,] tablica2D, int indeks, bool czyKolumna)
        {
            double[,] nowaTablica;
            if (czyKolumna)
            {
                nowaTablica = new double[tablica2D.GetLength(0), tablica2D.GetLength(1) - 1];

                for (int i = 0; i < nowaTablica.GetLength(0); i++)
                {
                    for (int j = 0; j < nowaTablica.GetLength(1); j++)
                    {
                        if (j >= indeks)
                        {
                            nowaTablica[i, j] = tablica2D[i, (j + 1)];
                        }
                        else
                            nowaTablica[i, j] = tablica2D[i, j];
                    }
                }
                return nowaTablica;
            }
            else
            {
                nowaTablica = new double[tablica2D.GetLength(0) - 1, tablica2D.GetLength(1)];

                for (int i = 0; i < nowaTablica.GetLength(0); i++)
                {
                    for (int j = 0; j < nowaTablica.GetLength(1); j++)
                    {
                        if (j >= indeks)
                        {
                            nowaTablica[i, j] = tablica2D[(i + 1), j];
                        }
                        else
                            nowaTablica[i, j] = tablica2D[i, j];
                    }
                }
                return nowaTablica;
            }
        }

        static void Main(string[] args)
        {
            //Zadanie1
             Zadanie1();
            //Zadanie2
            Zadanie2();
            //Zadanie3
            Zadanie3();
            //Zadanie4
            KontoBankowe Konto = new KontoBankowe("Tomasz", "Biegun");
            Konto.Uznanie(200);
            Konto.Uznanie(600);
            Konto.Uznanie(1000);
            Konto.Obciazenie(1000);
            Console.WriteLine("Imię: " + Konto.Imie + " Nazwisko: " + Konto.Nazwisko + " Numer konta: " + Konto.Numer + " Stan: " + Konto.Stan);
            Konto.WypiszHistorie();
            //Zadanie5
            Random random = new Random();

            double[,] mojatablica = new double[3, 6];

            for (int i = 0; i < mojatablica.GetLength(0); i++)
            {
                for (int j = 0; j < mojatablica.GetLength(1); j++)
                {
                    mojatablica[i, j] = random.Next(100);
                }
            }

            Console.WriteLine("Przed usunieciem kolumny:");
            WypiszTablice(mojatablica);
            var usunKolumne = Zadanie5(mojatablica, 2, false);
            Console.WriteLine("Wypisuje po usunieciu kolumny:");
            WypiszTablice(usunKolumne);


            //Console.WriteLine("Przed usunieciem wiersza:");
            //WypiszTablice(mojatablica);
            //var usunWiersz = Zadanie5(mojatablica, 3, false);
            //Console.WriteLine("Wypisuje po usunieciu wiersza:");
            //WypiszTablice(usunWiersz);
            Console.ReadKey();

        }
    }
}