namespace Pug.Models;

public interface IAtStreetAddress<TPostalCode> : IOnStreet<TPostalCode>
{
	string StreetNumber
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
}

public interface IAtStreetAddress : IAtStreetAddress<string>, IOnStreet {}