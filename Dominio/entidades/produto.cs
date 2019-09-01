namespace Dominio.entidades
{
    public class produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        
        public Categoria Categoria{ get; set; }
        
    }
}