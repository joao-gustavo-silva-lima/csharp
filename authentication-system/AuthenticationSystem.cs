using System.Collections.ObjectModel;

public struct Identity
{
    public string Email { get; set; }
    public string EyeColor { get; set; }
}

public class Authenticator
{
    private static class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    public readonly Identity Admin;
    public Authenticator(Identity admin)
    {
        Admin = admin;
    }

    private static readonly IDictionary<string, Identity> _developers
        = new Dictionary<string, Identity>
        {
            ["Bertrand"] = new Identity
            {
                Email = "bert@ex.ism",
                EyeColor = "blue"
            },

            ["Anders"] = new Identity
            {
                Email = "anders@ex.ism",
                EyeColor = "brown"
            }
        };
    private static readonly ReadOnlyDictionary<string, Identity> developers 
        = new(_developers)
    ;

    public IDictionary<string, Identity> GetDevelopers() => developers;
}
