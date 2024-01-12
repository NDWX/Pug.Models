namespace Pug.Models;

public interface InTerritoryBase : InCountry
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

public interface InTerritory<TPostalCode> : InTerritoryBase, IPostalCodeAssignable<TPostalCode>
{
}

public interface InTerritory : InTerritory<string>, IPostalCodeAssignable {}