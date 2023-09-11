namespace AtvRelacionamento1109.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Qtd { get; set; }
        public Produto Produto { get; set; }
    }
}
