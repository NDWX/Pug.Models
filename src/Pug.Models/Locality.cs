using Pug.Effable;

namespace Pug.Models;

public record Locality<TPostalCode> : INamed, InMunicipality<TPostalCode>
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

	public string Name
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
	
	public static implicit operator Locality<TPostalCode>( Street<TPostalCode> street ) => new ()
	{
		Name = street.Locality,
		PostalCode = street.PostalCode,
		Municipality = street.Municipality,
		Territory = street.Territory,
		Country = street.Country
	};
	
	public static implicit operator Locality<TPostalCode>( StreetAddress<TPostalCode> streetAddress ) => new ()
	{
		Name = streetAddress.Locality,
		PostalCode = streetAddress.PostalCode,
		Municipality = streetAddress.Municipality,
		Territory = streetAddress.Territory,
		Country = streetAddress.Country
	};
	
	public static implicit operator Locality<TPostalCode>( Dwelling<TPostalCode> dwelling ) => new ()
	{
		Name = dwelling.Locality,
		PostalCode = dwelling.PostalCode,
		Municipality = dwelling.Municipality,
		Territory = dwelling.Territory,
		Country = dwelling.Country
	};
}

public record Locality : Locality<string>, InMunicipality {}