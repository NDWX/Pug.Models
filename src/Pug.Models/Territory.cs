
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

	public static implicit operator Territory( InTerritoryBase municipality ) => new ()
	{
		Name = municipality.Territory,
		Country = municipality.Country
	};
}