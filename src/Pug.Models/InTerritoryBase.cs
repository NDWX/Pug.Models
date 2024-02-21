namespace Pug.Models;

public abstract record InTerritoryBase : InCountryBase {

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

public abstract record InTerritoryBase<TPostalCode> : InTerritoryBase, InTerritory<TPostalCode>
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
}