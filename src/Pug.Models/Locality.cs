using Pug.Effable;

namespace Pug.Models;

public record Locality : INamed, InMunicipality
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

	public string Municipality
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
}