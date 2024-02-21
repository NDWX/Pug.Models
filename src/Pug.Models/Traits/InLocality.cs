namespace Pug.Models;

public interface InLocality<TPostalCode> : InMunicipality<TPostalCode>, IsIn<Locality<TPostalCode>>
{
	string Locality
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
}

public interface InLocality : InLocality<string>, InMunicipality
{
}