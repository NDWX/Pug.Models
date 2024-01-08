namespace Pug.Models;

public class Street : InLocality
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
	
	public string Municipality
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
	
	public string Locality
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}

	public StreetName StreetName
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
}