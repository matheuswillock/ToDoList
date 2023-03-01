namespace ToDoList.SharedContext
{
    public abstract class Base
    {
        public Guid Id { get; set; }
        public Base() => Id = Guid.NewGuid();  

    }
}
