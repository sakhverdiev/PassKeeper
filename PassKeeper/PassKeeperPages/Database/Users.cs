using PassKeeperPages.UserClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PassKeeperPages.Database
{
    public static class Users
    {
        static public User? user { get; set; } = new();
        public static List<User>? users { get; set; }

        public static void LoadDatabase() =>
                    users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText("..\\..\\..\\Database\\usersDB.json"));
        public static void UpdateDatabase()
        {
            File.WriteAllText("..\\..\\..\\Database/usersDB.json",
                JsonSerializer.Serialize(users, new JsonSerializerOptions() { WriteIndented = true }));
        }

    }
}
