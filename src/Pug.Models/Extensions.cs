namespace Pug.Models;

public static class Extensions
{
	public static bool IsIn( this InCountry location, string country ) =>
		location.Country.Equals( country, StringComparison.InvariantCultureIgnoreCase );

	public static bool IsIn<TPostalCode>( this InTerritory<TPostalCode> location, Territory territory ) =>
		location.IsIn( territory.Country ) &&
		location.Territory.Equals( territory.Name, StringComparison.InvariantCultureIgnoreCase );

	internal static bool IsIn<TPostalCode>( this InTerritory<TPostalCode> location, InTerritory<TPostalCode> territory ) =>
		location.IsIn( territory.Country ) &&
		location.Territory.Equals( territory.Territory, StringComparison.InvariantCultureIgnoreCase );

	public static bool IsIn<TPostalCode>( this InMunicipality<TPostalCode> location, Municipality<TPostalCode> municipality ) =>
		location.IsIn( municipality as InTerritory<TPostalCode> ) &&
		location.Municipality.Equals( municipality.Name, StringComparison.InvariantCultureIgnoreCase );

	internal static bool IsIn<TPostalCode>( this InMunicipality<TPostalCode> location, InMunicipality<TPostalCode> municipality ) =>
		location.IsIn( municipality as InTerritory<TPostalCode> ) &&
		location.Municipality.Equals( municipality.Municipality, StringComparison.InvariantCultureIgnoreCase );

	public static bool IsIn<TPostalCode>( this InLocality<TPostalCode> location, Locality<TPostalCode> locality ) =>
		location.IsIn( locality as InMunicipality<TPostalCode> ) &&
		location.Locality.Equals( locality.Name, StringComparison.InvariantCultureIgnoreCase );

	internal static bool IsIn<TPostalCode>( this InLocality<TPostalCode> location, InLocality<TPostalCode> locality ) =>
		location.IsIn( locality as InMunicipality<TPostalCode> ) &&
		location.Locality.Equals( locality.Locality, StringComparison.InvariantCultureIgnoreCase );

	public static bool IsOn<TPostalCode>( this IOnStreet<TPostalCode> location, Street<TPostalCode> street ) =>
		location.IsIn( street as InLocality<TPostalCode> ) && location.StreetName == street.StreetName;

	public static bool IsOn<TPostalCode>( this IOnStreet<TPostalCode> location, IOnStreet<TPostalCode> street ) =>
		location.IsIn( street as InLocality<TPostalCode> ) && location.StreetName == street.StreetName;

	public static bool IsAt<TPostalCode>( this IAtStreetAddress<TPostalCode> location, StreetAddress<TPostalCode> streetAddress ) =>
		location.IsOn( streetAddress as IOnStreet<TPostalCode> ) && 
		location.StreetNumber == streetAddress.StreetNumber && location.Place == streetAddress.Place;

	public static bool IsAt<TPostalCode>( this IAtStreetAddress<TPostalCode> location, IAtStreetAddress<TPostalCode> streetAddress ) =>
		location.IsOn( streetAddress ) && location.StreetNumber == streetAddress.StreetNumber && location.Place == streetAddress.Place;
}