public partial class LoginModel
{
    public string? RedirectUrl { get; set; }

    public bool MergeSuccessful { get; set; }

    public bool ZipCodeDiffers { get; set; }

    public string? TimeslotUtc { get; set; }

    public long DeliveryZoneId { get; set; }

    public bool IsExternalLogin { get; set; }

    public bool IsFirstLogin { get; set; }

    public bool SaveExistingBasket { get; set; }
}

public class Credentials
{
    public string Username { get; set; }

    public string Password { get; set; }

    public bool AppInstalled { get; set; } = false;

    public bool AutoLogin { get; set; } = false;

    public bool CheckForExistingProducts { get; set; } = true;

    public bool DoMerge { get; set; } = true;

    public Credentials(string username, string password)
    {
        this.Username = username;
        this.Password = password;
    }
}
