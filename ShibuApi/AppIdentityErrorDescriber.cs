using Microsoft.AspNetCore.Identity;

namespace ShipbuApi;

public class AppIdentityErrorDescriber : IdentityErrorDescriber
{
    public override IdentityError ConcurrencyFailure()
    {
        return new IdentityError { Code = "ConcurrencyFailure", Description = "Eşzamanlılık hatası" };
    }
    public override IdentityError DefaultError()
    {
        return new IdentityError { Code = "DefaultError", Description = "Bir hata oluştu." };
    }
    public override IdentityError DuplicateEmail(string email)
    {
        return new IdentityError { Code = "DuplicateEmail", Description = $"{email} zaten kullanımdadır" };
    }
    public override IdentityError DuplicateRoleName(string role)
    {
        return new IdentityError { Code = "DuplicateRoleName", Description = $"{role} zaten kayıtlı." };
    }
    public override IdentityError DuplicateUserName(string userName)
    {
        return new IdentityError { Code = "DuplicateUserName", Description = $"{userName} zaten kayıtlı." };
    }
    public override IdentityError InvalidEmail(string email)
    {
        return new IdentityError { Code = "InvalidEmail", Description = $"{email} Geçersiz e-posta" };
    }
    public override IdentityError InvalidRoleName(string role)
    {
        return new IdentityError { Code = "InvalidRoleName", Description = $"{role} Geçersiz rol adı" };
    }
    public override IdentityError InvalidToken()
    {
        return new IdentityError { Code = "InvalidToken", Description = "Geçersiz doğrulama kodu" };
    }
    public override IdentityError InvalidUserName(string userName)
    {
        return new IdentityError { Code = "InvalidUserName", Description = $"Geçersiz kullanıcı adı" };
    }
    public override IdentityError LoginAlreadyAssociated()
    {
        return new IdentityError { Code = "LoginAlreadyAssociated", Description = "Giriş zaten ilişkili" };
    }
    public override IdentityError PasswordMismatch()
    {
        return new IdentityError { Code = "PasswordMismatch", Description = "Şifre eşleşmiyor" };
    }
    public override IdentityError PasswordRequiresDigit()
    {
        return new IdentityError { Code = "PasswordRequiresDigit", Description = "Şifre Rakam gerektirir" };
    }
    public override IdentityError PasswordRequiresLower()
    {
        return new IdentityError { Code = "PasswordRequiresLower", Description = "Şifre küçük harf gerektirir" };
    }
    public override IdentityError PasswordRequiresNonAlphanumeric()
    {
        return new IdentityError { Code = "PasswordRequiresNonAlphanumeric", Description = "Şifre en az bir sembol gerektirir" };
    }
    public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
    {
        return new IdentityError { Code = "PasswordRequiresUniqueChars", Description = $"Şifre en az {uniqueChars} adet benzersiz karakterler gerektirir" };
    }
    public override IdentityError PasswordRequiresUpper()
    {
        return new IdentityError { Code = "PasswordRequiresUpper", Description = "Şifre büyük harf gerektirir" };
    }
    public override IdentityError PasswordTooShort(int length)
    {
        return new IdentityError { Code = "PasswordTooShort", Description = $"Şifre çok kısa" };
    }
    public override IdentityError RecoveryCodeRedemptionFailed()
    {
        return new IdentityError { Code = "RecoveryCodeRedemptionFailed", Description = "Kurtarma kodu kullanılamadı" };
    }
    public override IdentityError UserAlreadyHasPassword()
    {
        return new IdentityError { Code = "UserAlreadyHasPassword", Description = "Kullanıcının zaten şifresi var" };
    }
    public override IdentityError UserAlreadyInRole(string role)
    {
        return new IdentityError { Code = "UserAlreadyInRole", Description = $"Kullanıcı zaten {role} rolü içindedir" };
    }
    public override IdentityError UserLockoutNotEnabled()
    {
        return new IdentityError { Code = "UserLockoutNotEnabled", Description = "Kullanıcı kilitleme etkin değil" };
    }
    public override IdentityError UserNotInRole(string role)
    {
        return new IdentityError { Code = "UserNotInRole", Description = $"Kullanıcı {role} rolü içinde değil" };
    }
}