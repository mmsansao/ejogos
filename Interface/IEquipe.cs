using EJOGOS.Models;
using System.Collections.Generic;

namespace EJOGOS.Interface
{
    public interface IEquipe
    {

        // Contrato
        // Representa os métodos que são obrigatórios em uma classe


        void Criar(Equipe novaEquipe);


        List<Equipe> LerEquipes();



    }
}
