namespace Pug.Models;

public static class Extensions
{
	public static bool IsIn( this InCountry location, string country ) =>
		location.Country.Equals( country, StringComparison.InvariantCultureIgnoreCase );

	public static bool IsIn( this InTerritory location, Territory territory ) =>
		location.IsIn( territory.Country ) &&
		location.Territory.Equals( territory.Name, StringComparison.InvariantCultureIgnoreCase );

	internal static bool IsIn( this InTerritory location, InTerritory territory ) =>
		location.IsIn( territory.Country ) &&
		location.Territory.Equals( territory.Territory, StringComparison.InvariantCultureIgnoreCase );

	public static bool IsIn( this InMunicipality location, Municipality municipality ) =>
		location.IsIn( municipality as InTerritory ) &&
		location.Municipality.Equals( municipality.Name, StringComparison.InvariantCultureIgnoreCase );

	internal static bool IsIn( this InMunicipality location, InMunicipality municipality ) =>
		location.IsIn( municipality as InTerritory ) &&
		location.Municipality.Equals( municipality.Municipality, StringComparison.InvariantCultureIgnoreCase );

	public static bool IsIn( this InLocality location, Locality locality ) =>
		location.IsIn( locality as InMunicipality ) &&
		location.Locality.Equals( locality.Name, StringComparison.InvariantCultureIgnoreCase );

	internal static bool IsIn( this InLocality location, InLocality locality ) =>
		location.IsIn( locality as InMunicipality ) &&
		location.Locality.Equals( locality.Locality, StringComparison.InvariantCultureIgnoreCase );

	public static bool IsOn( this IOnStreet location, Street street ) =>
		location.IsIn( street as InLocality ) && location.StreetName == street.StreetName;

	public static bool IsOn( this IOnStreet location, IOnStreet street ) =>
		location.IsIn( street as InLocality ) && location.StreetName == street.StreetName;

	public static bool IsAt( this IAtStreetAddress location, StreetAddress streetAddress ) =>
		location.IsOn( streetAddress ) && location.StreetNumber == streetAddress.StreetNumber;

	public static bool IsAt( this IAtStreetAddress location, IAtStreetAddress streetAddress ) =>
		location.IsOn( streetAddress ) && location.StreetNumber == streetAddress.StreetNumber;
}