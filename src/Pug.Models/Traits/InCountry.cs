namespace Pug.Models;

public interface InCountry : IsIn<string>
{
	string Country
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
}