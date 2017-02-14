namespace Coolector.Services.Medium.Modules
{
    public class HomeModule : ModuleBase
    {
        public HomeModule() : base(requireAuthentication: false)
        {
            Get("", args => "Welcome to the Coolector.Services.Medium API!");
        }
    }
}