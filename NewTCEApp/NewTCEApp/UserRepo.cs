using Firebase.Auth;
using System;
using System.Threading.Tasks;

namespace NewTCEApp
{
    public class UserRepo
    {
        static string webAPIKey = "AIzaSyABWNrZhog-7_F6SmKY5nLWfzWjUukz67E";
        FirebaseAuthProvider authProvider;

        public UserRepo()
        {
            authProvider = new FirebaseAuthProvider(new FirebaseConfig(webAPIKey));
        }

        public async Task<bool> Register(string email, string name, string password)
        {
            var token = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password, name);
            if (!string.IsNullOrEmpty(token.FirebaseToken))
            {
                return true; 
            }
            return false;
        }

        public async Task<string> SignIn(string email, string password)
        {
            try
            {
                var token = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
                return token.FirebaseToken;
            }
            catch(Exception e)
            {
                return string.Empty;
            }
            
        }
    }
}
