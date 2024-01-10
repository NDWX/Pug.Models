namespace Pug.Models;

public interface InTerritory : InCountry
{
	string Territory
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
}