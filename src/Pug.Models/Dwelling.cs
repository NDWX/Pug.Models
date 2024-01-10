using Pug.Effable;

namespace Pug.Models;

public record Dwelling : IAtStreetAddress
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
	
	public string StreetNumber
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
	
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