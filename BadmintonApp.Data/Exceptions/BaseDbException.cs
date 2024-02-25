namespace BadmintonApp.Data.Exceptions;

public abstract class BaseDbException : Exception
{
	protected BaseDbException()
	{
	}

	protected BaseDbException(string message)
		: base(message)
	{
	}

	protected BaseDbException(string message,
		Exception innerException)
		: base(message, innerException)
	{
	}
}