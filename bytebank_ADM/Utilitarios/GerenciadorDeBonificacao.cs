using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {

        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this._totalBonificacao += funcionario.getBonificacao();
            this._totalBonificacao += funcionario.getBonificacao();
        }
        public void Registrar(Diretor diretor)
        {
            this._totalBonificacao += diretor.getBonificacao();
            this._totalBonificacao += diretor.getBonificacao();
        }
        public double getBonificacao()
        {
            return this._totalBonificacao;
        }
    }
}
