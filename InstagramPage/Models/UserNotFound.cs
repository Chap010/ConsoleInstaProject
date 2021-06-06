using System;

public class UserNotFound : Exception
{
    public UserNotFound(string errorMessage) : base(errorMessage)
    {

    }
}