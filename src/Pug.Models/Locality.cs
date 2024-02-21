using Pug.Effable;

namespace Pug.Models;

public record Locality<TPostalCode> : InMunicipalityBase<TPostalCode>, INamed
{
	public string Name
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
	
	public static implicit operator Locality<TPostalCode>( InLocalityBase<TPostalCode> inLocality ) => new ()
	{
		Name = inLocality.Locality,
		PostalCode = inLocality.PostalCode,
		Municipality = inLocality.Municipality,
		Territory = inLocality.Territory,
		Country = inLocality.Country
	};
}

public record Locality : Locality<string>, InMunicipality {

	public static implicit operator Locality( InLocalityBase<string> inLocality ) => new ()
	{
		Name = inLocality.Locality,
		PostalCode = inLocality.PostalCode,
		Municipality = inLocality.Municipality,
		Territory = inLocality.Territory,
		Country = inLocality.Country
	};
}