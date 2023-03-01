using ToDoList.SharedContext;

namespace ToDoList.ContentConext
{
    public class FinishedCard : Base
    {
        public FinishedCard(User user)
        {
            User = user;
            ToDoCards = new List<ToDoCard>();
        }

        public User User { get; set; }
        public IList<ToDoCard> ToDoCards { get; set; }

    }
}