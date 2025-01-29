using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class SchoolContext:DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) 
        {
        }
        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Inscricao> Inscricao { get; set;}
        public DbSet<Cursos> Cursos { get; set;}
    }
}
