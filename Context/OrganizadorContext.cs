using Lista_de_Tarefas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lista_de_Tarefas.Context
{
    public class OrganizadorContext :DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext>options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefa {get; set;}
    }
}