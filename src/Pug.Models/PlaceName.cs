using Pug.Effable;

namespace Pug.Models;

public record PlaceName : INamed
{
	/// <summary>
	/// The generic of street name
	/// </summary>
	public string Type
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}

	/// <summary>
	/// The specific of street name
	/// </summary>
	public string Name
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}

	public static bool Equals( PlaceName x, PlaceName y )
	{
		if( ReferenceEquals( x, y ) ) return true;
		if( ReferenceEquals( x, null ) ) return false;
		if( ReferenceEquals( y, null ) ) return false;
		if( x.GetType() != y.GetType() ) return false;
		return x.Type == y.Type && x.Name == y.Name;
	}

	public static int GetHashCode( PlaceName obj )
	{
		unchecked
		{
			return ( ( obj.Type != null ? obj.Type.GetHashCode() : 0 ) * 397 ) ^ ( obj.Name != null ? obj.Name.GetHashCode() : 0 );
		}
	}
}