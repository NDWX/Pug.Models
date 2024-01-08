namespace Pug.Models;

public interface IOnStreet : InLocality
{
	StreetName StreetName
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
}