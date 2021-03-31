using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.I___Cadastro_de_Produtos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                erpNome.SetError(txtNome, "Insira o Nome!");
            }
            else if(txtCodigo.Text == "")
            {
                erpNome.SetError(txtNome, "");
                erpCodigo.SetError(txtCodigo, "Insira o Código!");
            }
            else if (txtEan.Text == "")
            {
                erpCodigo.SetError(txtCodigo, "");
                erpEan.SetError(txtEan, "Insira o EAN!");
            }
            else if (txtTipo.Text == "")
            {
                erpEan.SetError(txtEan, "");
                erpTipo.SetError(txtTipo, "Insira o Tipo!");
            }
            else if (txtQuantidade.Text == "")
            {
                erpTipo.SetError(txtTipo, "");
                erpQuantidade.SetError(txtQuantidade, "Insira o Quatidade!");
            }
            else if (txtCusto.Text == "")
            {
                erpQuantidade.SetError(txtQuantidade, "");
                erpCusto.SetError(txtCusto, "Insira o Custo!");
            }
            else if (txtVenda.Text == "")
            {
                erpCusto.SetError(txtCusto, "");
                erpVenda.SetError(txtVenda, "Insira o Venda!");
            }
            else if (txtEstoque.Text == "")
            {
                erpVenda.SetError(txtVenda, "");
                erpEstoque.SetError(txtEstoque, "Insira o Estoque!");
            }
            /*else if (txtGrupo.Text == "")
            {
                MessageBox.Show("Preencha o Grupo!");
            }*/
            else if (txtFabricante.Text == "")
            {
                erpEstoque.SetError(txtEstoque, "");
                erpFabricante.SetError(txtFabricante, "Insira o Fabricante!");
            }
            else if (txtMarca.Text == "")
            {
                erpFabricante.SetError(txtFabricante, "");
                erpMarca.SetError(txtMarca, "Insira o Marca!");
            }
            else
            {
                erpMarca.SetError(txtMarca, "");
                MessageBox.Show("Nome: " + txtNome.Text + "Codigo: " + txtCodigo.Text + "EAN: " + txtEan.Text + "Tipo: " + txtTipo.Text + "Quantidade: " + txtQuantidade.Text + "Custo: " + txtCusto.Text
                + "Venda: " + txtVenda.Text + "Estoque: " + txtEstoque.Text + "Grupo: " + txtGrupo.Text + "Observações: " + txtObservacoes.Text + "Fabricante: " + txtFabricante.Text + "Marca: " + txtMarca.Text);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpando os Textos
            txtNome.Text = "";
            txtCodigo.Text = "";
            txtEan.Text = "";
            txtTipo.Text = "";
            txtQuantidade.Text = "";
            txtCusto.Text = "";
            txtVenda.Text = "";
            txtEstoque.Text = "";
            txtGrupo.Text = "";
            txtObservacoes.Text = "";
            txtFabricante.Text = "";
            txtMarca.Text = "";
            // Limpando os Erros

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbGrupo_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void cmbGrupo_Enter(object sender, EventArgs e)
        {
            cmbGrupo.SelectedIndex = 0;
        }

        private void cmbGrupo_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
