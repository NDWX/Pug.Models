namespace Pug.Models
{
	public interface InLocality : InMunicipality
	{
		string Locality
		{
			get;
#if NETSTANDARD2_0
			set;
#else
			init;
#endif
		}
	}
}