#region Schleifen
int a = 0;
int b = 10;
while (a < b) //läuft solange die Bedingung true ist
{
	Console.WriteLine("while: " + a);
	if (a == 5)
		break; //Break beendet die Schleife
	a++;
}

while (true) //Endlosschleife
{
	//Code
}

int c = 0;
int d = 10;
do //läuft solange die Bedingung true ist UND mindestens einmal
{
	c++;
	if (c == 5)
		continue; //springt zum Kopf zurück
	Console.WriteLine("do-while: " + c);
}
while (c < d);

for (int i = 0; i < 10; i++) //for-Schleife: for(<Variable>;<Bedingung>;<Inkrement>)
{
	Console.WriteLine("for: " + i);
}

for (int i = 9; i > 0; i--) //Schleife die nach unten zählt
{
	Console.WriteLine("for-Rückwärts: " + i);
}

int[] zahlen = Enumerable.Range(0, 10).ToArray();
for (int i = 0; i < zahlen.Length; i++) //Array iterieren
{
	int current = zahlen[i];
	Console.WriteLine(current);
}

foreach (int zahl in zahlen) //Geht das Array durch und kann nicht daneben greifen (sicherer)
{
	Console.WriteLine(zahl);
}
#endregion

#region Enums
string[] tage = { "Montag", "Dienstag", "Mittwoch" }; //unpraktisch

Wochentag wochentag = Wochentag.Dienstag; //Wochentag Variable
Console.WriteLine(wochentag);

for (int i = 0; i < 7; i++) //int zu Enum casten
{
	Console.WriteLine((Wochentag) i);
}

string input = Console.ReadKey().KeyChar.ToString(); //int Eingabe zu Enum Parsen
Wochentag intInput = (Wochentag) int.Parse(input);
Console.WriteLine(intInput);

string strInput = Console.ReadLine(); //string Eingabe zu Enum Parsen
Wochentag stringInput = (Wochentag) Enum.Parse(typeof(Wochentag), strInput);
Console.WriteLine(stringInput);
#endregion

#region Switch
Wochentag tag = Wochentag.Montag;
if (tag == Wochentag.Montag) //Negativbeispiel
	Console.WriteLine("Wochenanfang");
else if (tag == Wochentag.Dienstag || tag == Wochentag.Mittwoch || tag == Wochentag.Donnerstag)
	Console.WriteLine("Wochenmitte");
else if (tag == Wochentag.Freitag || tag == Wochentag.Samstag || tag == Wochentag.Sonntag)
	Console.WriteLine("Wochenende");
else
	Console.WriteLine("Etwas ist schiefgelaufen");

switch (tag) //Vergleich mit If-Else
{
	case Wochentag.Montag:
		Console.WriteLine("Wochenanfang");
		break;
	case Wochentag.Dienstag:
	case Wochentag.Mittwoch:
	case Wochentag.Donnerstag:
		Console.WriteLine("Wochenmitte");
		break;
	case Wochentag.Freitag:
	case Wochentag.Samstag:
	case Wochentag.Sonntag:
		Console.WriteLine("Wochenende");
		break;
	default:
		Console.WriteLine("Etwas ist schiefgelaufen");
		break;
}

switch (tag) //Boolsche Logik
{
	case >= Wochentag.Montag and <= Wochentag.Freitag:
		Console.WriteLine("Wochentag");
		break;
	case Wochentag.Samstag or Wochentag.Sonntag:
		Console.WriteLine("Wochenende");
		break;
}
#endregion

enum Wochentag
{
	Montag,
	Dienstag,
	Mittwoch,
	Donnerstag,
	Freitag,
	Samstag,
	Sonntag
}