namespace assignment4
{
    public class User {

        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Authorization { get; set; }

        public User(string _UserName,string _Password,bool _Authorization) {
        
            UserName = _UserName;
            Password = _Password;
            Authorization = _Authorization;
        }
    }
    }

