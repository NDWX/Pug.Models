namespace Pug.Models;

public interface InTerritory<TPostalCode> : InCountry, IPostalCodeAssignable<TPostalCode>, IsIn<Territory>
{
	string Territory
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
}

public interface InTerritory : InTerritory<string>, IPostalCodeAssignable {}