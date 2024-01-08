
using Pug.Effable;
using static System.String;

namespace Pug.Models
{
	public class Territory : INamed<string>, InCountry
	{
		public string Name { get; set; }
		
		public string Country { get; set; }

		public static implicit operator Territory( Municipality municipality ) => new Territory()
		{
			Name = municipality.Territory,
			Country = municipality.Country
		};
	}
}