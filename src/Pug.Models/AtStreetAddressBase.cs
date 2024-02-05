namespace Pug.Models;

public abstract record AtStreetAddressBase<TPostalCode> : OnStreetBase<TPostalCode>, IAtStreetAddress<TPostalCode>
{
	public bool IsIn( StreetAddress<TPostalCode> location )
	{
		if( location is null )
			return false;

		return IsIn( location.Country ) && Territory == location.Territory &&
				Municipality == location.Municipality && Locality == location.Locality &&
				StreetName == location.StreetName && StreetNumber == location.StreetNumber && Place == location.Place;
	}
	
	public string StreetNumber
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