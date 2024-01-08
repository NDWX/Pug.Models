namespace Pug.Models
{
	public interface InLocality : InMunicipality
	{
		string Locality { get; set; }
	}
}