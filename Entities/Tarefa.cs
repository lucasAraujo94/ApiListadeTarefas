using System.ComponentModel.DataAnnotations;
using static Lista_de_Tarefas.Entities.EnumStatustarefa;

namespace Lista_de_Tarefas.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data {get;set;}
        
        public EnumStatusTarefa Status {get;set;}
    }
}