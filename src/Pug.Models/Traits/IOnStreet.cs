namespace Pug.Models;

public interface IOnStreet<TPostalCode> : InLocality<TPostalCode>, IsIn<Street<TPostalCode>>
{
	PlaceName StreetName
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
}

public interface IOnStreet : IOnStreet<string>, InLocality
{
}