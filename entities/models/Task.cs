namespace TaskManagementSystem.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } // Pendiente, En Proceso, Completada
        public int AssignedId { get; set; }
        public User AssignedTo { get; set; }
    }
}
