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
	
	public static implicit operator Street<TPostalCode>( StreetAddress<TPostalCode> streetAddress ) => new ()
	{
		StreetName = streetAddress.StreetName,
		Locality = streetAddress.Locality,
		PostalCode = streetAddress.PostalCode,
		Municipality = streetAddress.Municipality,
		Territory = streetAddress.Territory,
		Country = streetAddress.Country
	};
	
	public static implicit operator Street<TPostalCode>( Dwelling<TPostalCode> dwe ) => new ()
	{
		StreetName = dwe.StreetName,
		Locality = dwe.Locality,
		PostalCode = dwe.PostalCode,
		Municipality = dwe.Municipality,
		Territory = dwe.Territory,
		Country = dwe.Country
	};
}

public record Street : Street<string>, InLocality {}