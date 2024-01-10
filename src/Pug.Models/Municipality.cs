using Pug.Effable;

namespace Pug.Models;

public record Municipality : INamed, InTerritory
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
		
	public string Territory
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

	public static implicit operator Municipality( Locality locality ) => new Municipality()
	{
		Name = locality.Municipality,
		Territory = locality.Territory,
		Country = locality.Country
	};
}