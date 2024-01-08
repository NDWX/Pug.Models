using Pug.Effable;

namespace Pug.Models
{
	public class Municipality : INamed<string>, InTerritory
	{
		public string Name { get; set; }
		
		public string Territory { get; set; }
		
		public string Country { get; set; }

		public static implicit operator Municipality( Locality locality ) => new Municipality()
		{
			Name = locality.Municipality,
			Territory = locality.Territory,
			Country = locality.Country
		};
	}
}