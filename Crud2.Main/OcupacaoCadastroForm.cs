using Crud2.Main.Data;
using Crud2.Main.Domain;
using System;
using System.Windows.Forms;

namespace Crud2.Main
{
    public partial class OcupacaoCadastroForm : Form {
        private int ocupacaoId = 0;
        private Ocupacao ocupacao = null;
        private OcupacaoCadastroForm(){
            InitializeComponent();
        }
        public static Ocupacao Novo(){
            var form = new OcupacaoCadastroForm();
            if (form.ShowDialog() == DialogResult.OK)
                return form.ocupacao;
            return null;
        }
        public static Ocupacao Alterar(int ocupacaoId){
            var form = new OcupacaoCadastroForm();
            form.ocupacaoId = ocupacaoId;
            if (form.ShowDialog() == DialogResult.OK)
                return form.ocupacao;
            return null;
        }
        private void OcupacaoCadastroForm_Shown(object sender, EventArgs e){
            if (ocupacaoId != 0){
                IUnitOfWork _uow = null;
                try {
                    _uow = new UnitOfWork();
                    _uow.BeginTransaction();
                    var ocupacaoRepository = new OcupacaoRepository(_uow);
                    ocupacao = ocupacaoRepository.GetById(ocupacaoId);
                    IdTextBox.Text = ocupacao.Ocupacaoid.ToString();
                    NomeTextBox.Text = ocupacao.Nome;
                    CodigocboTextBox.Text = ocupacao.Codigocbo;

                    _uow.Commit();
                } catch {
                    _uow.RollBack();
                    throw;
                }
            }
        }
        private void SalvarButton_Click(object sender, EventArgs e){
            IUnitOfWork _uow = null;
            try {
                _uow = new UnitOfWork();
                _uow.BeginTransaction();
                var ocupacaoRepository = new OcupacaoRepository(_uow);
                if (ocupacaoId == 0){
                    ocupacao = new Ocupacao();
                }
                ocupacao.Nome = NomeTextBox.Text;
                ocupacao.Codigocbo = CodigocboTextBox.Text;
                if (ocupacaoId == 0){
                    ocupacaoRepository.Add(ocupacao);
                } else {
                    ocupacaoRepository.Update(ocupacao);
                }
                _uow.Commit();
            } catch {
                _uow.RollBack();
                throw;
            }
        }
    }
}
