using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Cursos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CursosId { get; set; }
        public string titulo { get; set; }
        public int Creditos { get; set; }
        public ICollection<Inscricao> Inscricao { get; set;}
    }
}
