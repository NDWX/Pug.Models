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
}

public record Locality : Locality<string>, InMunicipality {}