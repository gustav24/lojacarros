namespace lojacarros.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaCarroId { get; set; }
        public CategoriaCarro CategoriaCarro { get; set; }
    }
}
