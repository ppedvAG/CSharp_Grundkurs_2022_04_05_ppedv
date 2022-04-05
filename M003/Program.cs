#region Arrays
int[] zahlen = new int[5]; //Array mit Länge 5 (0-4)
zahlen[2] = 5; //Zugriff auf Stelle 2 mit Zuweisung
Console.WriteLine(zahlen[2]);

int[] zahlenDirekt = new int[] { 2, 4, 6, 8, 10 }; //Direkte Initialisierung

int[] zahlenDirektKurz = new[] { 2, 4, 6, 8, 10 };

int[] zahlenDirektNochKuerzer = { 2, 4, 6, 8, 10 };

Console.WriteLine(zahlen.Length); //Länge vom Array (5)

bool hatDrei = zahlenDirekt.Contains(3); //Schauen ob Array eine Zahl enthält

zahlen.Sum();
zahlen.Min();
zahlen.Max();

//zahlen[0]; Erstes Element statt First()
//zahlen[zahlen.Length - 1]; Letztes Element statt Last()

int[,] matrix = new int[3, 2];
matrix[1, 1] = 4;
Console.WriteLine(matrix[1, 1]);
Console.WriteLine(matrix.Length); //Anzahl an Feldern (6)
Console.WriteLine(matrix.Rank); //Gibt die Anzahl an Dimensionen zurück (2)
Console.WriteLine(matrix.GetLength(1)); //Länge von angegebener Dimension

int[,] matrixDirekt = //Direkte Initialisierung wie oben
{
	{ 1, 2, 3 },
	{ 4, 5, 6 }
};

//Array Darstellung:
// | 1, 2, 3 |
// | 4, 5, 6 |
#endregion

#region Bedingungen
int zahl1 = 5;
int zahl2 = 7;

if (zahl1 == zahl2)
{
	//Wird ausgeführt wenn zahl1 gleich zahl2
}

if (zahl1 != zahl2)
{
	//Wird ausgeführt wenn zahl1 ungleich zahl2
}

if (zahl1 >= zahl2)
{
	//Wenn zahl1 größer oder gleich zahl2
}
else
{
	//Wenn nicht ins if gegangen
}

if (zahl1 == 7) //Keine Klammern bei einzeiligen Codeblöcken möglich
	Console.WriteLine("Zahl1 gleich 7");
else if (zahl1 == 5) //Else If
	Console.WriteLine("Zahl1 gleich 5");

//&& ist true wenn beide Werte true sind
//|| ist true wenn einer der beiden Werte true ist
bool istMittwoch = false;
bool istBewoelkt = true;
if (istMittwoch && istBewoelkt)
{

}

if (istMittwoch || istBewoelkt)
{

}

if (zahl1 == 5 && zahl2 == 7) //Mehrere Bedingungen
{
	Console.WriteLine("Zahl1 ist 5 und Zahl2 ist 7");
}

//Fragezeichen Operator
//Wenn Bedingung true, dann führe Code hinter Fragezeichen aus
//Braucht immer ein Else (:)
Console.WriteLine(zahl1 == 5 && zahl2 == 7 ? "Zahl1 ist 5 und Zahl2 ist 7" : "");
#endregion