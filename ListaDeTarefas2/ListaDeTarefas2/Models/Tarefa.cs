using ListaDeTarefas2.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Intrinsics.X86;

namespace ListaDeTarefas2.Models
{
    [Table("Tarefa")]
    public class Tarefa /*: ITarefa*/
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("data_criacao")]
        public DateTime DataCriacao { get; set; }

        [Column("responsavel")]
        public string Responsavel { get; set; }

        [Column("concluida")]
        public bool Concluida { get; set; }

        //public List<Tarefa> ConsultarTarefas()
        //{
        //    //
        //}

        //public List<Tarefa> ConsultarTarefasConcluidas()
        //{
        //    //
        //}

        //public List<Tarefa> ConsultarTarefasEmAberto()
        //{
        //    //
        //}

        //public void IncluirTarefa()
        //{
        //    //
        //}

        //public void AtualizarDescricao()
        //{
        //    //
        //}

        //public void ExcluirTarefa()
        //{
        //    //
        //}

    }
}
