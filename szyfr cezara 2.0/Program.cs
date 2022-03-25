Console.WriteLine("Wpisz Wielkie litery");

String wpisz, wypisz;
char[] litery = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 
'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

wpisz = Convert.ToString(Console.ReadLine());
char[] tablica = wpisz.ToCharArray();
char[] tablicaa = new char[tablica.Length];

for (int i = 0; i < tablica.Length; i++) 
{
    char litera = tablica[i];
    if (tablicaa[i] == ' ' && tablica[i] == '\n') continue;
    int a = Array.IndexOf(litery, litera);
    int cezar = (a + 5) % 26;
    char SC = litery[cezar];
    tablicaa[i] = SC;
}
wypisz = String.Join("", tablicaa);
Console.WriteLine(wypisz);