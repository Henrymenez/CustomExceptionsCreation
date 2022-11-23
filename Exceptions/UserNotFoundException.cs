using System;

public class UserNotFoundException : Exception
{
	public UserNotFoundException()
	{
        public string UserName { get; }

    public override string Message => "User Not Found!";

    public UserNotFoundException() { }

        public UserNotFoundException(string message)
        : base(message) { }

        public UserNotFoundException(string message, Exception inner)
        : base(message, inner) { }

    public UserNotFoundException(string userName)
    {
        UserName = userName;
    }
}
}
