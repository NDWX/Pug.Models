
using Pug.Effable;

namespace Pug.Models;

public record Territory : InCountryBase, INamed
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

	public static implicit operator Territory( Municipality municipality ) => new Territory()
	{
		Name = municipality.Territory,
		Country = municipality.Country
	};
	
	public static implicit operator Territory( Street street ) => new ()
	{
		Name = street.Locality,
		Country = street.Country
	};
	
	public static implicit operator Territory( StreetAddress streetAddress ) => new ()
	{
		Name = streetAddress.Locality,
		Country = streetAddress.Country
	};

	public static implicit operator Territory( Dwelling dwelling ) => new ()
	{
		Name = dwelling.Locality,
		Country = dwelling.Country
	};
}