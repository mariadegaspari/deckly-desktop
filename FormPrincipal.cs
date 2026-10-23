using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeckly
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            //EXIBIR A DATA ATUAL DO SISTEMA
            statuslbData.Text = DateTime.Now.ToShortDateString();

            //EXIBIR A HORA ATUAL DO SISTEMA
            statuslbHora.Text = DateTime.Now.ToShortTimeString();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            //FECHAR A APLICAÇÃO - SISTEMA TODO
            if (MessageBox.Show("Você deseja sair do sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuCargo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCargo>().Count() > 0)
            {
                MessageBox.Show("Cadastro de cargos já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                FormCargo fCadCargo = new FormCargo();
                //TORNAR O FORMULÁRIO CADASTRO DE CARGO FILHO DO FORM PRINCIPAL
                //fCadCargo.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fCadCargo.Show();
            }
        }

        private void menuCadFuncionario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormFuncionario>().Count() > 0)
            {
                MessageBox.Show("Cadastro de funcionários já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                FormFuncionario fCadFuncionario = new FormFuncionario();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fCadFuncionario.Show();
            }
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuCadMarca_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormMarca>().Count() > 0)
            {
                MessageBox.Show("Cadastro de marca já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                FormMarca fCadMarca = new FormMarca();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fCadMarca.Show();
            }
        }

        private void menuCadCategoria_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FormCategoria>().Count() > 0)
            {
                MessageBox.Show("Cadastro de categorias já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                FormCategoria fCadCategoria = new FormCategoria();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fCadCategoria.Show();
            }

        }

        private void menuCadCliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCliente>().Count() > 0)
            {
                MessageBox.Show("Cadastro de clientes já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                FormCliente fCadCliente = new FormCliente();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fCadCliente.Show();
            }

        }

        private void menuCadProduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("Cadastro de produto já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                FormProduto fCadProduto = new FormProduto();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fCadProduto.Show();
            }
        }

        private void menuConsFun_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsFuncionario>().Count() > 0)
            {
                MessageBox.Show("Consulta de funcionário já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                formConsFuncionario fConsFun = new formConsFuncionario();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fConsFun.Show();
            }
        }

        private void menuConsCar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsCargo>().Count() > 0)
            {
                MessageBox.Show("Consulta de cargo já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                FormConsCargo fConsCar = new FormConsCargo();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fConsCar.Show();
            }
        }

        private void menuConsCat_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsCategoria>().Count() > 0)
            {
                MessageBox.Show("Consulta de categoria já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                FormConsCategoria fConsCat = new FormConsCategoria();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fConsCat.Show();
            }
        }

        private void menuConsMar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsMarca>().Count() > 0)
            {
                MessageBox.Show("Consulta de marca já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                FormConsMarca fConsMar = new FormConsMarca();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fConsMar.Show();
            }
        }

        private void menuConsCliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsCliente>().Count() > 0)
            {
                MessageBox.Show("Consulta de cliente já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                FormConsCliente fConsCli = new FormConsCliente();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fConsCli.Show();
            }
        }

        private void menuConsProduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsProduto>().Count() > 0)
            {
                MessageBox.Show("Consulta de produto já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                FormConsProduto fConsPro = new FormConsProduto();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fConsPro.Show();
            }
        }

        private void menuRelFunc_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelFuncionario>().Count() > 0)
            {
                MessageBox.Show("Relatório de Funcionários já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                formRelFuncionario fRelFunc = new formRelFuncionario();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fRelFunc.Show();
            }
        }

        private void menuRelCli_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelCliente>().Count() > 0)
            {
                MessageBox.Show("Relatório de Clientes já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                formRelCliente fRelCli = new formRelCliente();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fRelCli.Show();
            }
        }

        private void menuRelPro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelProduto>().Count() > 0)
            {
                MessageBox.Show("Relatório de Clientes já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                formRelProduto fRelPro = new formRelProduto();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fRelPro.Show();
            }
        }

        private void menuRealizarVenda_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formVenda>().Count() > 0)
            {
                MessageBox.Show("Formulário de venda já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //CRIAR OBJETO DO FORM E INSTANCIAR O OBJETO
                formVenda fVenda = new formVenda();
                //TORNAR O FORMULÁRIO CADASTRO DE FUNCIONÁRIO FILHO DO FORM PRINCIPAL
                //fCadFuncionario.MdiParent = this;
                //ABRIR O FORMULÁRIO 
                fVenda.Show();
            }
        }

        private void menuCadastrar_Click(object sender, EventArgs e)
        {
            //menuCadastrar.ForeColor = Color.Black;
        }

        private void menuCadastrar_BackColorChanged(object sender, EventArgs e)
        {
            //menuCadastrar.ForeColor = Color.Black;
        }
    }  
}
