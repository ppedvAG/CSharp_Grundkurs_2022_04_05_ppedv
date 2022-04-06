namespace M006;

public class Person
{
	public Person() { }

	public Person(string vorname, string nachname)
	{
		Vorname = vorname;
		Nachname = nachname;
	}

	public Person(string vorname, string nachname, DateTime gebDat) : this(vorname, nachname) //über this der Konstruktor darüber aufgerufen (zuerst)
	{
		Geburtsdatum = gebDat;
	}

	#region	Alte Schreibweise
	private string Vorname;

	public string GetVorname()
	{
		return Vorname;
	}

	public void SetVorname(string vorname)
	{
		Vorname = vorname;
	}
	#endregion

	private string nachname;

	public string Nachname
	{
		get => nachname;
		set
		{
			if (!string.IsNullOrEmpty(value) && value.Length >= 2) //Input Check
				nachname = value;
		}
	}

	private int gehalt = 2000;

	public int Gehalt
	{
		get //Von außen ein Get-Only Property
		{
			return gehalt;
		}
		private set => gehalt = value; //Private Set: nur in der Person verwendbar
	}

	public DateTime Geburtsdatum { get; set; } = DateTime.Now;
}
