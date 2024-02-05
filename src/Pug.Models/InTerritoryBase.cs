namespace Pug.Models;

public abstract record InTerritoryBase<TPostalCode> : InCountryBase, InTerritory<TPostalCode>
{
	public TPostalCode PostalCode
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}

	public bool IsIn( Territory location )
	{
		if( location is null )
			return false;

		return base.IsIn( location.Country ) && Territory == location.Name;
	}

	public string Territory
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
}