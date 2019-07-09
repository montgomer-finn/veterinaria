using System;
using Modelo;
using Servico;

namespace AppTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            Servico.DataBaseCreate.CreateDataBase();
            var atendimentoServico            = new AtendimentoServico();
            var animalServico                 = new AnimalServico();
            var clienteServico                = new ClienteServico();
            var exameServico                  = new ExameServico();
            var medicamentoServico            = new MedicamentoServico();
            var veterinarioServico            = new VeterinarioServico();

            var dono1 = new Cliente("Ayrton", "01234567891");
            clienteServico.Inserir(dono1);

            dono1 = clienteServico.ObterPorID(1);

            var animal1 = new Animal("Nala", new DateTime(2018, 5, 14), dono1.HumanoID);
            animalServico.Inserir(animal1);

            animal1 = animalServico.ObterPorID(1);

            var veterinario = new Veterinario("Dr Hans Chucrutes", "78945612302");
            veterinarioServico.Inserir(veterinario);

            veterinario = veterinarioServico.ObterPorID(2);

            var medicamento = new Medicamento("Remedio pra verme", 10, "Mata o verme dentro do bucho do bich", 5.99);
            medicamentoServico.Inserir(medicamento);

            medicamento = medicamentoServico.ObterPorID(1);

            var exame = new Exame("Exame de verme", "Usado para ver se o animal tem verme", 14.99);
            exameServico.Inserir(exame);

            exame = exameServico.ObterPorID(1);

            var atendimento = new AtendimentoBuilder().ParaAnimal(animal1).ComVeterinario(veterinario).ComExame(exame)
                .ComMedicamento(medicamento).ComDescricao("Constatado que tinha verme").JaRealizado().NaDataAtual().Build();

            animalServico.ObterHumano(animal1);
            Console.WriteLine(animal1.Humano.Nome);

            atendimentoServico.ObterExames(atendimento);

            foreach(var atendimentoExame in atendimento.AtendimentoExames)
            {
                Console.WriteLine(atendimentoExame.Exame.Nome);
            }
        }
    }
}
