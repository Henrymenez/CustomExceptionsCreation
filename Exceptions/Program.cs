namespace Exceptions
{
    public class User
    {

        private string UserName { get; set; }
        private string Password { get; set; }
        public User(string userName, string password)
        {

            UserName = userName;
            Password = password;
        }

        public string GetUsername()
        {
            return UserName;
        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            List<User> user = new List<User>();
            user.Add(new User("Messi", "pass1234"));
            user.Add(new User("Ronaldo", "1234pass"));

            string username = "";
            User CurrentUser;

            Console.WriteLine("Insert Username");
            username = Console.ReadLine();
            //check against db
            CurrentUser = user.FirstOrDefault(a => a.GetUsername() == username);

            if (CurrentUser == null)
            {
                UserNotFoundException userNotFoundException = new UserNotFoundException("UserName Not Found", username);
                throw userNotFoundException;
            }
            Console.WriteLine(CurrentUser);
        }
    }
}