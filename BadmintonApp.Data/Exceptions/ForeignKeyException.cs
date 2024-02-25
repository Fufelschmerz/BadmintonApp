namespace BadmintonApp.Data.Exceptions;

public class ForeignKeyException : BaseDbException
{
	public ForeignKeyException()
	{
	}

	public ForeignKeyException(string message)
		: base(message)
	{
	}

	public ForeignKeyException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}