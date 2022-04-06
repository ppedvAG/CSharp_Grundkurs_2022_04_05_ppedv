#region Variablen
//Variable: Typ Name
int zahl; //Variablendefinition
zahl = 5; //Variablenzuweisung
Console.WriteLine(zahl); //cw + Tab + Tab: Console.WriteLine()

int zahlMitZuweisung = 5; //Definition mit Zuweisung
Console.WriteLine(zahlMitZuweisung);

int zahlMalZwei = zahl * 2; //Arithmetik
Console.WriteLine(zahlMalZwei);

string stadt = "Berlin"; //Text mit doppeltem Hochkomma (")
Console.WriteLine(stadt);

char zeichen = 'A'; //Einzelnes Zeichen mit einzelnen Hochkommas (')
Console.WriteLine(zeichen);

double kommazahl = 33.55; //Kommazahl mit Punkt statt Beistrich
Console.WriteLine(kommazahl);

float floatZahl = 33.55f; //Kommazahl ist standardmäßig ein double, konvertieren mit f am Ende
Console.WriteLine(floatZahl);

decimal geld = 332_869_512_365.44m; //Konvertieren mit M, für Geldwerte verwenden statt double oder float
Console.WriteLine(geld); //_ für Trennzeichen

#region Stringoperationen
string stadtZahl = stadt + zahl; //+ um Strings zu verbinden
Console.WriteLine(stadtZahl);

//String Interpolation
string stadtZahlModern = $"{stadt}{zahl}"; //$ vor dem String um Interpolation zu kennzeichnen
Console.WriteLine(stadtZahlModern);

int parameter = 20;
Console.WriteLine("Max ist {0} Jahre alt {1}", parameter, geld); //Parameterschreibweise ({0} = parameter, {1} = geld)

string newLine = "Hallo ich bin \n ein Umbruch"; //\n: Umbruch
Console.WriteLine(newLine);

string tab = "Hallo ich bin \t ein Tabulator"; //\t: Tabulator
Console.WriteLine(tab);

string verbatim = @"Hallo ich
bin\n ein String";
Console.WriteLine(verbatim); //Verbatim String: mit @, nimmt alles wörtlich was im String steht (keine Escapesequenzen)

string pfad = @"C:\Users"; //Verbatim String bei Pfaden sehr nützlich
Console.WriteLine(pfad);
#endregion
#endregion

#region Kommentare
/*
	Mehrzeiliger
	Kommentar
*/

//Strg + K, C: Alle markierten Zeilen auskommentieren
//Strg + K, U: Alle markierten Zeilen einkommentieren
//Console.WriteLine("Text");
//Console.WriteLine("Text");
//Console.WriteLine("Text");
//Console.WriteLine("Text");
#endregion

#region Eingabe
string eingabe = Console.ReadLine(); //Zeileneingabe bis Enter
Console.WriteLine(eingabe);

char eingabeKey = Console.ReadKey().KeyChar; //Zeicheneingabe ohne Enter
Console.WriteLine(eingabeKey);

string zahlEingabe = Console.ReadLine();
int parsedZahl = int.Parse(zahlEingabe); //Parse: Konvertierung von String zu Int
Console.WriteLine(parsedZahl);

string doubleEingabe = Console.ReadLine(); //Eingabe in Deutschland mit , als Komma
double parsedDouble = double.Parse(doubleEingabe); //Außerhalb mit .
Console.WriteLine(parsedDouble);

bool boolParse = bool.Parse(Console.ReadLine());
Console.WriteLine(boolParse);
#endregion

#region Typecasting
int ganzzahl = 50; //Impliziter Cast
double implizit = ganzzahl;
Console.WriteLine(implizit);

double doubleZahl = 50.5;
int intZahl = (int) doubleZahl; //Expliziter Cast (Typ in Klammer vor Variable angeben)
Console.WriteLine(intZahl);

Convert.ToInt32("123"); //Alte Konvertierung
int.Parse("123"); //Moderne Konvertierung
#endregion

#region Mathematik
int zahl1 = 7;
int zahl2 = 3;
Console.WriteLine(zahl1 % zahl2); //Modulo: Gibt den Rest einer Division zurück

zahl1++; //Erhöhe Zahl um 1 und weise das Ergebnis zu
zahl1 += 1; //Gleiches wie ++
Console.WriteLine(zahl1 + 1); //Erhöhe Zahl um 1 und weise das Ergebnis nicht zu

zahl1 += zahl2; //+=: weise das Ergebnis zu, funktioniert mit -*/%

double round = 2.6;
Math.Round(round); //Aufrunden da 2.6
Math.Floor(round); //Immer abrunden
Math.Ceiling(round); //Immer aufrunden

Math.Min(zahl1, zahl2);
Math.Max(zahl1, zahl2);
#endregion