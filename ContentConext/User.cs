using ToDoList.SharedContext;

namespace ToDoList.ContentConext
{
    public class User : Base
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IList<ToDoCard> ToDoCards { get; set; }
        public FinishedCard? FinishedCard { get; set; }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;

            ToDoCards = new List<ToDoCard>();
        }
    }
}
