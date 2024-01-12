namespace Pug.Models;

public interface IPostalCodeAssignable<TPostalCode>
{
	TPostalCode PostalCode
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
}

public interface IPostalCodeAssignable : IPostalCodeAssignable<string> {}