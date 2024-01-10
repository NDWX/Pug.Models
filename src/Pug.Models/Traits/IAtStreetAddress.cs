namespace Pug.Models;

public interface IAtStreetAddress : IOnStreet
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
}