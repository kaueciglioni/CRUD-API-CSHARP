using System.ComponentModel;

namespace CRUD_CSHARP.Enums
{
    public enum StatusTarefas
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("Concluído")]
        Concluido = 3
    }
}
