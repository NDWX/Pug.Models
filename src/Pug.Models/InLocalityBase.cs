namespace Pug.Models;

public abstract record InLocalityBase<TPostalCode> : InMunicipalityBase<TPostalCode>, InLocality<TPostalCode>
{
	public bool IsIn( Locality<TPostalCode> location )
	{
		if( location is null )
			return false;
		
		return IsIn( location.Country ) && Territory == location.Territory &&
				Municipality == location.Municipality && Locality == location.Name;
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
}