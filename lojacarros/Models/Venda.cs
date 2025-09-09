namespace lojacarros.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int CarroId { get; set; }
        public Carro Carro { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal Valor { get; set; }
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
