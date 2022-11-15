using Crud2.Main.Data;
using Crud2.Main.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud2.Main
{
    public partial class OcupacaoConsultaForm : Form
    {

        private List<Ocupacao> listaOcupacao = new List<Ocupacao>();

        public OcupacaoConsultaForm()
        {
            InitializeComponent();
        }

        private void OcupacaoConsultaForm_Load(object sender, EventArgs e)
        {
        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            IUnitOfWork _uow = null;
            try
            {
                _uow = new UnitOfWork();
                _uow.BeginTransaction();
                var ocupacaoRepository = new OcupacaoRepository(_uow);
                listaOcupacao.Clear();
                bindingSource2.DataSource = null;
                listaOcupacao.AddRange(ocupacaoRepository.GetOcupacao_NomeCodigocbo(NomeTextBox.Text, CodigocboTextBox.Text));
                bindingSource2.DataSource = listaOcupacao;
                dataGridView1.DataSource = bindingSource2;

                _uow.Commit();
            }
            catch
            {
                _uow.RollBack();
                throw;
            }
        }

        private void AlterarOcupacaoToolStripButton_Click(object sender, EventArgs e)
        {
            IUnitOfWork _uow = null;
            try
            {
                _uow = new UnitOfWork();
                _uow.BeginTransaction();
                var ocupacaoRepository = new OcupacaoRepository(_uow);
                if (bindingSource2.Count <= 0) return;
                var ocupacao = (Ocupacao)bindingSource2.Current;
                OcupacaoCadastroForm.Alterar(ocupacao.Ocupacaoid);
                listaOcupacao.Clear();
                bindingSource2.DataSource = null;
                listaOcupacao.AddRange(ocupacaoRepository.GetOcupacao_NomeCodigocbo(NomeTextBox.Text, CodigocboTextBox.Text));
                bindingSource2.DataSource = listaOcupacao;
                dataGridView1.DataSource = bindingSource2;
                _uow.Commit();
            }
            catch
            {
                _uow.RollBack();
                throw;
            }
        }

        private void NovoOcupacaoToolStripButton_Click(object sender, EventArgs e)
        {
            var ocupacao = OcupacaoCadastroForm.Novo();
        }

        private void ExcluirToolStripButton_Click(object sender, EventArgs e)
        {
            if (bindingSource2.Count <= 0)
                return;
            var ocupacao = (Ocupacao)bindingSource2.Current;
            if (MessageBox.Show("Deseja realmente excluir a ocupação " + ocupacao.Nome + "?", "Confirme a exclusão!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IUnitOfWork _uow = null;
                try
                {
                    _uow = new UnitOfWork();
                    _uow.BeginTransaction();
                    var ocupacaoRepository = new OcupacaoRepository(_uow);
                    ocupacaoRepository.Remove(ocupacao);
                    listaOcupacao.Clear();
                    bindingSource2.DataSource = null;
                    listaOcupacao.AddRange(ocupacaoRepository.GetOcupacao_NomeCodigocbo(NomeTextBox.Text, CodigocboTextBox.Text));
                    bindingSource2.DataSource = listaOcupacao;
                    dataGridView1.DataSource = bindingSource2;
                    _uow.Commit();
                }
                catch
                {
                    _uow.RollBack();
                    throw;
                }
            }
        }
    }
}
