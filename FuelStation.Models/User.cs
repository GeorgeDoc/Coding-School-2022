using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models {
    public class User {
        public string Username { get; set; }
        public string Password { get; set; }
        public int PermissionLevel { get; set; }

        public User() {

        }
        public User(string username, string _password) {
            username = username;
            Password = _password;
            PermissionLevel = 0;
        }
    }
}
