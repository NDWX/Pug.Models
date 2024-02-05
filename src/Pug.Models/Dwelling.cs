using Pug.Effable;

namespace Pug.Models;

public record Dwelling<TPostalCode> : AtStreetAddressBase<TPostalCode>
{
	public Reference Structure
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
	
	public string Floor
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}

	public string Type
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}

	public string Identifier
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
}

public record Dwelling : Dwelling<string>, IAtStreetAddress {}