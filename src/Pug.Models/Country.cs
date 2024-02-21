using Pug.Effable;

namespace Pug.Models;

public record Country : INamed
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

	public static implicit operator Country( InCountryBase municipality ) => new ()
	{
		Name = municipality.Country
	};

	public static implicit operator Country( InTerritoryBase municipality ) => new ()
	{
		Name = municipality.Country
	};

	public static implicit operator Country( Municipality municipality ) => new ()
	{
		Name = municipality.Country
	};
	
	public static implicit operator Country( Street street ) => new ()
	{
		Name = street.Country
	};
	
	public static implicit operator Country( StreetAddress streetAddress ) => new ()
	{
		Name = streetAddress.Country
	};

	public static implicit operator Country( Dwelling dwelling ) => new ()
	{
		Name = dwelling.Country
	};
}