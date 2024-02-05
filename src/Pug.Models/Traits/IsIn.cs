namespace Pug.Models;

public interface IsIn<TLocation>
{
	bool IsIn( TLocation location );
}