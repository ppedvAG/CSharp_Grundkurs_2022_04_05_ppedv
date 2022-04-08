namespace M011
{
	public static class ExtensionMethods
	{
		public static int Quersumme(this int x)
		{
			return x.ToString().ToCharArray().Sum(c => (int) char.GetNumericValue(c));
		}

		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> e)
		{
			return e.OrderBy(x => Random.Shared.Next());
		}
	}
}
