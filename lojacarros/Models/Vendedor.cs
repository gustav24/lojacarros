namespace lojacarros.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public ICollection<Venda> Vendas { get; set; }
    }
}
