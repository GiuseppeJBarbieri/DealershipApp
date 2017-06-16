using System;

public class LoginEvent
{
    public delegate void LoginEventHandler(object source, EventArgs args);
    public event LoginEventHandler LoginEvent;

}
