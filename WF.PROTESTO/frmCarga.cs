using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.PROTESTO
{
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string arquivo;
            StringBuilder sb = new StringBuilder();

            if (txtCarga.Text != "")
            {
                arquivo = txtCarga.Text;
                string retLerArquivo;
                HttpResponseMessage retorno;
                string url = System.Configuration.ConfigurationSettings.AppSettings["urlApi"];
                string endpoint = System.Configuration.ConfigurationSettings.AppSettings["endpointProtesto"];
                LerArquivo lerArquivo = new LerArquivo();
                retLerArquivo = lerArquivo.ProcessarArquivo(arquivo);

                retorno = ApiClient.ImportarCarga(url + endpoint, retLerArquivo);

                if (retorno.IsSuccessStatusCode)
                {
                    MessageBox.Show("Importação efetuada com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha na importação: " + retorno.Content.ReadAsStringAsync().Result);
                }
            }
            else
            {
                MessageBox.Show("Nenhum Arquivo Selecionado!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                txtCarga.Text = openFileDialog1.FileName;
            }
        }
    }
}
