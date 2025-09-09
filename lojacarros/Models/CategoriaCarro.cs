namespace lojacarros.Models
{
    public class CategoriaCarro
    {
        public int Id { get; set; }
        public string Nome { get; set; } 
        public string Descricao { get; set; }

        public ICollection<Carro> Carros { get; set; }
    }
}
