using System.ComponentModel;


namespace BlazorAuth.Shared
{
    public enum Role
    {
        [Description("Administrator")]
        Administrator,
        [Description("user")]
        User
    }
}
