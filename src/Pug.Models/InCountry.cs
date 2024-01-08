namespace Pug.Models
{
	public interface InCountry
	{
		string Country
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