namespace Pug.Models
{
	public static class Extensions
	{
		public static bool IsIn( this InCountry location, string country ) =>
			location.Country.Equals( country, StringComparison.InvariantCultureIgnoreCase );
		
		public static bool IsIn( this InTerritory location, Territory territory ) =>
			location.IsIn( territory.Country ) &&
			location.Territory.Equals( territory.Name, StringComparison.InvariantCultureIgnoreCase );

		public static bool IsIn( this InMunicipality location, Municipality municipality ) =>
			( location as InTerritory ).IsIn( municipality ) &&
			location.Municipality.Equals( municipality.Name, StringComparison.InvariantCultureIgnoreCase );

		public static bool IsIn( this InLocality location, Locality locality ) =>
			( location as InMunicipality ).IsIn( locality ) &&
			location.Locality.Equals( locality.Name, StringComparison.InvariantCultureIgnoreCase );
	}
}