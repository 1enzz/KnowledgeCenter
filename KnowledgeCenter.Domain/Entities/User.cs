namespace KnowledgeCenter.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; } = string.Empty;
        public int Age { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public string Document { get; private set; }

        public User(Guid id, string name, string phoneNumber, int age, DateTime birthDate, string email, string document, string createdBy, DateTime createdAt, DateTime? updatedAt, DateTime? deletedAt)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Age = age;
            BirthDate = birthDate;
            Email = email;
            Document = document;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            DeletedAt = deletedAt;
        }
    }
}
