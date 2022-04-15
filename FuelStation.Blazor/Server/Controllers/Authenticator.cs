using FuelStation.Models;

namespace FuelStation.Blazor.Server.Controllers {
    public class Authenticator {

        public Authenticator() { }
        public Authenticator(User user) {
            username = user.Username;
            password = user.Password;
            persmissionLevel = 0;
        }

        private string username {get; set;}
        private string password { get; set; }
        private int persmissionLevel { get; set; }

        public bool Authenticate(string username, string password) { 
            bool check = false;
            if (username.Trim() == "admin" && password.Trim() == "admin") {
                persmissionLevel = 3;
                check = true;
            } 
            if (username.Trim() == "cashier" && password.Trim() == "cashier") {
                persmissionLevel = 2;
                check = true;
            } 
            if (username.Trim() == "staff" && password.Trim() == "staff") {
                persmissionLevel = 1;
                check = true;
            } 
            return check;
        }
    }
}
