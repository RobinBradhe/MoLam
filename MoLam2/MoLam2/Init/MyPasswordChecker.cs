using Umbraco.Cms.Core.Security;

namespace MoLam2.Init
{
    public class MyPasswordChecker : IBackOfficeUserPasswordChecker
    {
        public Task<BackOfficeUserPasswordCheckerResult> CheckPasswordAsync(BackOfficeIdentityUser user, string password)
        {
            var result = (password == "test")
              ? Task.FromResult(BackOfficeUserPasswordCheckerResult.ValidCredentials)
              : Task.FromResult(BackOfficeUserPasswordCheckerResult.InvalidCredentials);

            return result;
        }
    }
}
