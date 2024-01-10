namespace Pug.Models;

public sealed class StreetName : PlaceName, IEquatable<StreetName>
{

	public bool Equals( StreetName other )
	{
		if( ReferenceEquals( null, other ) ) return false;
		if( ReferenceEquals( this, other ) ) return true;
		
		return Type == other.Type && Name == other.Name;
	}
	
	public override bool Equals( object obj )
	{
		return ReferenceEquals( this, obj ) || obj is StreetName other && Equals( other );
	}

	public override int GetHashCode()
	{
		unchecked
		{
			return ( ( Type != null ? Type.GetHashCode() : 0 ) * 397 ) ^ ( Name != null ? Name.GetHashCode() : 0 );
		}
	}

	public static bool operator ==( StreetName left, StreetName right )
	{
		return Equals( left, right );
	}

	public static bool operator !=( StreetName left, StreetName right )
	{
		return !Equals( left, right );
	}
	
}