namespace WebApplication1.Models
{
    public class Inscricao
    {
        public enum Grade
        {
            A, B, C, D, E
        }
        public int InscricaoId { get; set; }
        public int CursosId { get; set; }
        public int AlunosId { get; set;}
        public Grade? GradeCurricular { get; set; }
        public Cursos Cursos { get; set; }
        public Alunos Alunos { get; set; }
    }
}
