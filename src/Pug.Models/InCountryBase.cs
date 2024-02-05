namespace Pug.Models;

public abstract record InCountryBase : InCountry
{
	public bool IsIn( string location )
	{
		return this.Country == location;
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