using System;

namespace Exceptions{
public class UserNotFoundException : Exception
{
	  public string UserName { get; }

    public override string Message => "User Not Found!";

        public UserNotFoundException(string message)
        : base(message) { }

        public UserNotFoundException(string message, Exception inner)
        : base(message, inner) { }

    public UserNotFoundException(string message,string userName)
    {
        UserName = userName;
    }
}

}
