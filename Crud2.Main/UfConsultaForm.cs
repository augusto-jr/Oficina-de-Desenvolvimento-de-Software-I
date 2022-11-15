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

namespace Crud2.Main {
    public partial class UfConsultaForm : Form {

        private List<Uf> listaUf = new List<Uf>();
        
        public UfConsultaForm(){
            InitializeComponent();
        }

        private void UfConsultaForm_Load(object sender, EventArgs e){   
        }

        private void consultarButton_Click(object sender, EventArgs e){
            IUnitOfWork _uow = null;
            try {
                _uow = new UnitOfWork();
                _uow.BeginTransaction();
                var ufRepository = new UfRepository(_uow);
                listaUf.Clear();
                bindingSource1.DataSource = null;
                listaUf.AddRange(ufRepository.GetUfs_SiglaNome(UfTextBox.Text,EstadoTextBox.Text));
                bindingSource1.DataSource = listaUf;
                dataGridView1.DataSource = bindingSource1;
                
                _uow.Commit();
            } catch {
                _uow.RollBack();
                throw;
            }
        }

        private void AlterarUfToolStripButton_Click(object sender, EventArgs e){
            IUnitOfWork _uow = null;
            try {
                _uow = new UnitOfWork();
                _uow.BeginTransaction();
                var ufRepository = new UfRepository(_uow);
                if (bindingSource1.Count <= 0) return;
                var uf = (Uf)bindingSource1.Current;
                UfCadastroForm.Alterar(uf.Id);
                listaUf.Clear();
                bindingSource1.DataSource = null;
                listaUf.AddRange(ufRepository.GetUfs_SiglaNome(UfTextBox.Text, EstadoTextBox.Text));
                bindingSource1.DataSource = listaUf;
                dataGridView1.DataSource = bindingSource1;
                _uow.Commit();
            } catch {
                _uow.RollBack();
                throw;
            }
        }

        private void NovoUfToolStripButton_Click(object sender, EventArgs e){
            var uf = UfCadastroForm.Novo();
        }

        private void ExcluirToolStripButton_Click(object sender, EventArgs e){
            if (bindingSource1.Count <= 0)
                return;
            var uf = (Uf)bindingSource1.Current;
            if(MessageBox.Show("Deseja realmente excluir a UF " + uf.Nome +"?","Confirme a exclusão!",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                IUnitOfWork _uow = null;
                try {
                    _uow = new UnitOfWork();
                    _uow.BeginTransaction();
                    var ufRepository = new UfRepository(_uow);
                    ufRepository.Remove(uf);
                    listaUf.Clear();
                    bindingSource1.DataSource = null;
                    listaUf.AddRange(ufRepository.GetUfs_SiglaNome(UfTextBox.Text, EstadoTextBox.Text));
                    bindingSource1.DataSource = listaUf;
                    dataGridView1.DataSource = bindingSource1;
                    _uow.Commit();
                } catch {
                    _uow.RollBack();
                    throw;
                }
            }
        }
    }
}
