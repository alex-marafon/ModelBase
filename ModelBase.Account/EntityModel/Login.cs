using ModelBasa.Shared.ValueObjects.Account;

namespace ModelBase.Account.EntityModel;
public class Login
{
    public Email Email { get; set; }
    public Password Password { get; set; }
}
