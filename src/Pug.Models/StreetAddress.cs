namespace Pug.Models;

public record StreetAddress<TPostalCode> : IOnStreet<TPostalCode>
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
	
	public string Municipality
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
	
	public TPostalCode PostalCode
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
	
	public string Locality
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}

	public PlaceName StreetName
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
	
	public PlaceName Place
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}

	public string StreetNumber
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
	
	public static implicit operator StreetAddress<TPostalCode>( Dwelling<TPostalCode> dwelling ) => new ()
	{
		Place = dwelling.Place,
		StreetNumber = dwelling.StreetNumber,
		StreetName = dwelling.StreetName,
		Locality = dwelling.Locality,
		PostalCode = dwelling.PostalCode,
		Municipality = dwelling.Municipality,
		Territory = dwelling.Territory,
		Country = dwelling.Country
	};
}

public record StreetAddress : StreetAddress<string>, IOnStreet
{
}