namespace Pug.Models;

public interface InMunicipality<TPostalCode> : InTerritory<TPostalCode>, IsIn<Municipality<TPostalCode>>
{
	string Municipality
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
}

public interface InMunicipality : InMunicipality<string>, InTerritory {}