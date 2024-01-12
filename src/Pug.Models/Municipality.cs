using Pug.Effable;

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
}

public record Municipality : Municipality<string>, InTerritory {}