namespace Pug.Models;

public record StreetAddress<TPostalCode> : OnStreetBase<TPostalCode>
{
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