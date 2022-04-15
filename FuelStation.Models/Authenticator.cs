using FuelStation.Models;

namespace FuelStation.Models {
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

        public bool Authenticate(User user) { 
            bool check = false;
            if (user.Username.Trim() == "admin" && user.Password.Trim() == "admin") {
                persmissionLevel = 3;
                check = true;
                user.PermissionLevel = 3;
            } 
            if (user.Username.Trim() == "cashier" && user.Password.Trim() == "cashier") {
                persmissionLevel = 2;
                check = true;
                user.PermissionLevel = 2;
            } 
            if (user.Username.Trim() == "staff" && user.Password.Trim() == "staff") {
                persmissionLevel = 1;
                check = true;
                user.PermissionLevel = 1;
            } 
            return check;
        }
    }
}
