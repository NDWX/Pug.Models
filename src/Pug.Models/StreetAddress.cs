namespace Pug.Models;

public class StreetAddress : IOnStreet
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
	
	public PlaceName Place
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}

	public string StreetNumber
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
}