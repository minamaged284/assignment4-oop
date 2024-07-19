

namespace assignment4
    
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        User[] users = new User[3]
        {
            new User("mina","mina123456",true),
            new User("beshoy","beshoy123456",true),
            new User("michael","michael123456",false),


        };
        private bool authentication;
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Authorization { get; set; }
        private int index { get; set; }





        User defaultUser = new User("mina","123456",true);
        public BasicAuthenticationService(string _UserName, string _Password)
        {

            UserName = _UserName;
            Password = _Password;
            
        }
        public bool AuthenticateUser()
        {
            for (int i = 0; i < users.Length; i++) {

                if (UserName == users[i].UserName && Password == users[i].Password)
                {
                    authentication = true;
                    index = i;
                    Console.WriteLine("Success");
                    return true;
                }
                
                     
            }
            authentication = false;
            Console.WriteLine("User name or password is invalid");
            return false;
        }

        public bool AuthorizeUser()
        {
            if (authentication==true && users[index].Authorization==true)
            {
                Console.WriteLine("Authorized");
                return true;
            }
            else {
                Console.WriteLine("Unauthorized");
                return false; }
        }

        static void result()
        {

        }
    }
    }

