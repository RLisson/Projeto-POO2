using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Acessa_dados.Interface;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Acessa_dados
{
    public class AcessaDadosTurma : AcessaDados<Turma>
    {
        Model<Professor> _professorModel;
        Model<Aluno> _alunoModel;
        public AcessaDadosTurma(Model<Turma> model, string arquivo, Model<Professor> professorModel, Model<Aluno> alunoModel) : base(model, arquivo)
        {
            _professorModel = professorModel;
            _alunoModel = alunoModel;
        }

        public override void EscritaDados()
        {
            throw new NotImplementedException();
        }

        public override void LeituraDados()
        {
            throw new NotImplementedException();
        }
    }
}
