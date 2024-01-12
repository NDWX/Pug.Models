
using Pug.Effable;
using static System.String;

namespace Pug.Models;

public record Territory : INamed, InCountry
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
		
	public string Country
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}

	public static implicit operator Territory( MunicipalityBase municipality ) => new Territory()
	{
		Name = municipality.Territory,
		Country = municipality.Country
	};
}