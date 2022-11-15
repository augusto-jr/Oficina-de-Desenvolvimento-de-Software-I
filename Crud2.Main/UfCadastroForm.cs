using Crud2.Main.Data;
using Crud2.Main.Domain;
using System;
using System.Windows.Forms;

namespace Crud2.Main
{
    public partial class UfCadastroForm : Form {
        private int ufId = 0;
        private Uf uf = null;
        private UfCadastroForm(){
            InitializeComponent();
        }
        public static Uf Novo(){
            var form = new UfCadastroForm();
            if (form.ShowDialog() == DialogResult.OK)
                return form.uf;
            return null;
        }
        public static Uf Alterar(int ufId){
            var form = new UfCadastroForm();
            form.ufId = ufId;
            if (form.ShowDialog() == DialogResult.OK)
                return form.uf;
            return null;
        }
        private void UfCadastroForm_Shown(object sender, EventArgs e){
            if(ufId != 0){
                IUnitOfWork _uow = null;
                try{
                    _uow = new UnitOfWork();
                    _uow.BeginTransaction();
                    var ufRepository = new UfRepository(_uow);
                    uf = ufRepository.GetById(ufId);
                    IdTextBox.Text = uf.Id.ToString();
                    EstadoTextBox.Text = uf.Nome;
                    UfTextBox.Text = uf.Sigla;
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
                var ufRepository = new UfRepository(_uow);
                if (ufId == 0){
                    uf = new Uf();
                }
                uf.Nome = EstadoTextBox.Text;
                uf.Sigla = UfTextBox.Text;
                if (ufId == 0){
                    ufRepository.Add(uf);
                } else {
                    ufRepository.Update(uf);
                }
                _uow.Commit();
            } catch {
                _uow.RollBack();
                throw;
            }
        }
    }
}
