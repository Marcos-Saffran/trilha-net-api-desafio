using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrilhaApiDesafio.ModelViews;

namespace TrilhaApiDesafio.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }

        public ErrosDeValidacao ValidarTarefa()
        {
            var errosDeValidacao = new ErrosDeValidacao();

            if (Data == DateTime.MinValue)
                errosDeValidacao.Mensagens.Add("A data da tarefa não pode ser vazia");

            if (!Enum.IsDefined(typeof(EnumStatusTarefa), Status))
                errosDeValidacao.Mensagens.Add("O status da tarefa não pode ser inválido");


            return errosDeValidacao;
        }
    }
}