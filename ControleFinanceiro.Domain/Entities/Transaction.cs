namespace ControleFinanceiro.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateOnly Date { get; set; }
        public User User { get; set; } = null!;
        public Category Category { get; set; } = null!;
    }
}
