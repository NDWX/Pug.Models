namespace Pug.Models;

public abstract record MunicipalityBase : InTerritoryBase
{
	public string Country
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
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

public record Municipality<TPostalCode> : MunicipalityBase, InTerritory<TPostalCode>
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

	public string Name 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
	
	public static implicit operator Municipality<TPostalCode>( Locality<TPostalCode> locality ) => new ()
	{
		PostalCode = locality.PostalCode,
		Name = locality.Municipality,
		Territory = locality.Territory,
		Country = locality.Country
	};
	
	public static implicit operator Municipality<TPostalCode>( Street<TPostalCode> street ) => new ()
	{
		PostalCode = street.PostalCode,
		Name = street.Municipality,
		Territory = street.Territory,
		Country = street.Country
	};
	
	public static implicit operator Municipality<TPostalCode>( StreetAddress<TPostalCode> streetAddress ) => new ()
	{
		PostalCode = streetAddress.PostalCode,
		Name = streetAddress.Municipality,
		Territory = streetAddress.Territory,
		Country = streetAddress.Country
	};
	
	public static implicit operator Municipality<TPostalCode>( Dwelling<TPostalCode> dwelling ) => new ()
	{
		PostalCode = dwelling.PostalCode,
		Name = dwelling.Municipality,
		Territory = dwelling.Territory,
		Country = dwelling.Country
	};
}

public record Municipality : Municipality<string>, InTerritory {}