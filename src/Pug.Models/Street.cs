namespace Pug.Models;

public record Street<TPostalCode> : InLocalityBase<TPostalCode>
{
	public PlaceName StreetName
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
	
	public static implicit operator Street<TPostalCode>( OnStreetBase<TPostalCode> streetAddress ) => new ()
	{
		StreetName = streetAddress.StreetName,
		Locality = streetAddress.Locality,
		PostalCode = streetAddress.PostalCode,
		Municipality = streetAddress.Municipality,
		Territory = streetAddress.Territory,
		Country = streetAddress.Country
	};
}

public record Street : Street<string>, InLocality {
	
	public static implicit operator Street( OnStreetBase<string> streetAddress ) => new ()
	{
		StreetName = streetAddress.StreetName,
		Locality = streetAddress.Locality,
		PostalCode = streetAddress.PostalCode,
		Municipality = streetAddress.Municipality,
		Territory = streetAddress.Territory,
		Country = streetAddress.Country
	};
}