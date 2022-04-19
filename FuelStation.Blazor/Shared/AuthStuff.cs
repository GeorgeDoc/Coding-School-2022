using FuelStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared {
    public class AuthStuff {

        public AuthStuff() { }

        public readonly string localUserFile = "localUserFile.json";
		public readonly string registeredUsers = "registeredUsers.json";
		//protected readonly string localUserFile = "localUserFile.json";

		public User _User { get; set; }
		public void SaveUser(User user) {
			if (File.Exists(localUserFile)) {
				LoadUser();
			}
			string jsonStr = System.Text.Json.JsonSerializer.Serialize(user);
			File.WriteAllText(localUserFile, jsonStr);
		}

		public bool LoadUser() {
			bool fileExixts = File.Exists(localUserFile);
			if (fileExixts) {
				string jsonStr = File.ReadAllText(localUserFile);
				_User = JsonSerializer.Deserialize<User>(jsonStr);
			}
			return fileExixts;
		}

	}
}
