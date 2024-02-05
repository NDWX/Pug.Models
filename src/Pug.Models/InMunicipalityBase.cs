namespace Pug.Models;

public abstract record InMunicipalityBase<TPostalCode> : InTerritoryBase<TPostalCode>, InMunicipality<TPostalCode>
{
	public string Municipality
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}

	public bool IsIn( Municipality<TPostalCode> location )
	{
		if( location is null )
			return false;

		return base.IsIn( location.Country ) && Territory == location.Territory &&
				Municipality == location.Name;
	}
}