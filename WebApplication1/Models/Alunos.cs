namespace WebApplication1.Models
{
    public class Alunos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sobrenome { get; set; }
        public DateTime InscricaoData { get; set; }
        public ICollection<Inscricao> Inscricao {get; set;}

    }
}
