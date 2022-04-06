public class Program
{
	static void Main(string[] args)
	{
		ConsoleKeyInfo key = Console.ReadKey(); //Rückgabewert ConsoleKeyInfo in Variable schreiben
		Console.WriteLine(); //Kein Rückgabewert (keine Variable möglich)

		PrintSumme(4, 9); //Springt in Funktion mit den beiden Parametern

		int summe = Addiere(4, 9); //Return Wert steht jetzt in Summe

		int summe3 = Addiere(3, 4, 5); //Addiere Überladung

		int summeParams = Addiere(1, 2, 3, 4, 5, 6, 7, 8, 9, 10); //Beliebig viele Parameter

		int x = AddiereOderSubtrahiere(4, 2); //Bool add muss nicht übergeben werden

		int subtr;
		int add = AddiereUndSubtrahiere(5, 2, out subtr); //Eine Variable out die geoutet wird

		(int, int) ergebnisse = AddiereUndSubtrahiere(5, 2);
		int ergebnisAdd = ergebnisse.Item1;
		int ergebnisSub = ergebnisse.Item2;
	}

	static void PrintSumme(int zahl1, int zahl2) //Parameter: getrennt mit Beistrich
	{
		Console.WriteLine(zahl1 + zahl2);
	}

	static int Addiere(int zahl1, int zahl2)
	{
		return zahl1 + zahl2; //Return gibt Wert zurück
	}

	static int Addiere(int zahl1, int zahl2, int zahl3) //Überladene Funktion (gleichnamige Funktion mit unterschiedliche Parameter)
	{
		return zahl1 + zahl2 + zahl3;
	}

	//params: Beliebig viele Parameter
	//Jede Funktion kann nur einmal params haben und params muss der letzte Parameter sein
	static int Addiere(params int[] zahlen)
	{
		//int summe = 0;
		//foreach (int i in zahlen)
		//	summe += i;
		//return summe;
		return zahlen.Sum();
	}

	//Optionaler Parameter (add)
	//Muss nicht übergeben beim Aufruf der Funktion und nimmt den Standardwert (true) an
	//Optionale Parameter müssen am Ende stehen
	static int AddiereOderSubtrahiere(int zahl1, int zahl2, bool add = true)
	{
		return add == true ? zahl1 + zahl2 : zahl1 - zahl2;
	}

	static int AddiereUndSubtrahiere(int z1, int z2, out int sub) //Out als zweiter return Wert
	{
		sub = z1 - z2;
		return z1 + z2;
	}

	static (int, int) AddiereUndSubtrahiere(int z1, int z2) //Tupel statt Out
	{
		return (z1 + z2, z1 - z2);
	}
}