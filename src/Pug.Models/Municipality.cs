namespace Pug.Models;

public record Municipality<TPostalCode> : InTerritoryBase<TPostalCode>
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
	
	public static implicit operator Municipality<TPostalCode>( InMunicipalityBase<TPostalCode> inMunicipality ) => new ()
	{
		PostalCode = inMunicipality.PostalCode,
		Name = inMunicipality.Municipality,
		Territory = inMunicipality.Territory,
		Country = inMunicipality.Country
	};
}

public record Municipality : Municipality<string>, InTerritory
{
	public static implicit operator Municipality( InMunicipalityBase<string> inMunicipality ) => new ()
	{
		PostalCode = inMunicipality.PostalCode,
		Name = inMunicipality.Municipality,
		Territory = inMunicipality.Territory,
		Country = inMunicipality.Country
	};
}