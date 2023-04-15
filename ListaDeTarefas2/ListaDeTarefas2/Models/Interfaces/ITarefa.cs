namespace ListaDeTarefas2.Models.Interfaces
{
    public interface ITarefa
    {

        public List<Tarefa> ConsultarTarefas();

        public List<Tarefa> ConsultarTarefasConcluidas();

        public List<Tarefa> ConsultarTarefasEmAberto();

        public void IncluirTarefa();

        public void AtualizarDescricao();

        public void ExcluirTarefa();

    }
}
