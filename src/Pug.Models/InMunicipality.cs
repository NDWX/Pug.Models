namespace Pug.Models
{
	public interface InMunicipality : InTerritory
	{
		string Municipality
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