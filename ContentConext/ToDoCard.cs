using ToDoList.SharedContext;

namespace ToDoList.ContentConext
{
    public class ToDoCard : Base
    {

        public ToDoCard(string title, string description, User user)
        {
            Title = title;
            Description = description;
            User = user;
            Done = false;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public bool Done { get; set; }

    }
}
