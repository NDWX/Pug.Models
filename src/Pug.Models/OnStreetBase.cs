namespace Pug.Models;

public abstract record OnStreetBase<TPostalCode> : InLocalityBase<TPostalCode>, IOnStreet<TPostalCode>
{
	public PlaceName StreetName
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}

	public bool IsIn( Street<TPostalCode> location )
	{
		if( location is null )
			return false;
		
		return IsIn( location.Country ) && Territory == location.Territory &&
				Municipality == location.Municipality && Locality == location.Locality && StreetName == location.StreetName;
	}
}