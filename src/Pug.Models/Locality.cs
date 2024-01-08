using Pug.Effable;

namespace Pug.Models
{
	public class Locality : INamed<string>, InMunicipality
	{
		public string Name { get; set; }
		
		public string PostalCode { get; set; }
		
		public string Municipality { get; set; }
		
		public string Territory { get; set; }
		
		public string Country { get; set; }
	}
}