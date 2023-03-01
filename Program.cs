using ToDoList.ContentConext;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User("mathwillock", "matheus@email.com", "asd123");
            var card1 = new ToDoCard("Limpar a casa", "", user);
            var card2 = new ToDoCard("enviar email", "", user);
            var card3 = new ToDoCard("fazer uma ligação", "", user);
            var card4 = new ToDoCard("reunião", "", user);

            user.ToDoCards.Add(card1);
            user.ToDoCards.Add(card2);
            user.ToDoCards.Add(card3);
            user.ToDoCards.Add(card4);

            var finishedCards = new FinishedCard(user); ;

            Console.WriteLine($"\n{user.Username} tem os os to-do cards não concluidos abaixo:");

            foreach (var item in user.ToDoCards) 
            {
                if (user.ToDoCards.IndexOf(item) == 2)
                    item.Done = true;

                var done = item.Done == false ? "Não terminado!" : "Terminado!";

                if (item.Done) 
                {
                    finishedCards.ToDoCards.Add(item);
                }
                
                if(!item.Done)
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"Titulo: {item.Title}\nDescrição: {item.Description}\n{done}");
                }
            }

            Console.WriteLine("------------------------------------------------");

            if (finishedCards.ToDoCards.Any() == false)
            {
                Console.WriteLine($"\n\n{user.Username} não possui cards concluidos!");
            }
            else {
                Console.WriteLine($"\n\nCards concluidos do {user.Username}:");
                foreach (var item in finishedCards.ToDoCards)
                {
                    var done = item.Done == false ? "Não terminado!" : "Terminado!";

                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"Titulo: {item.Title}\nDescrição: {item.Description}\n{done}");
                }
            }
            Console.WriteLine("------------------------------------------------\n");






        }
    }
}