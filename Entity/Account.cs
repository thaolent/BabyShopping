namespace Baby_ShoppingOnline.Entity;

public class Account
{
    public int AccountId { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Phone { get; set; }

}
