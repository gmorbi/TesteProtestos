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
    public partial class frmProtestos : Form
    {
        public frmProtestos()
        {
            InitializeComponent();
        }

        private void frmProtestos_Load(object sender, EventArgs e)
        {
            CarregarProtestos();
        }

        public void RefreshForm()
        {
            CarregarProtestos();
        }

        private void CarregarProtestos()
        {
            string url = System.Configuration.ConfigurationSettings.AppSettings["urlApi"];
            string endpoint = System.Configuration.ConfigurationSettings.AppSettings["endpointProtesto"];
            string jsonReturnProtestos;
            HttpResponseMessage retorno;
            
            retorno = ApiClient.RetornarProtestos(url + endpoint);

            jsonReturnProtestos = retorno.Content.ReadAsStringAsync().Result;

            if (jsonReturnProtestos != null)
            {
                dynamic dnyObj = JsonConvert.DeserializeObject(jsonReturnProtestos);
                gridProtestos.DataSource = dnyObj;

                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                {
                    btnEditar.Name = "btnEditar";
                    btnEditar.HeaderText = "Editar";
                    btnEditar.Text = "Editar";
                    btnEditar.UseColumnTextForButtonValue = true;
                    gridProtestos.Columns.Add(btnEditar);
                }

                gridProtestos.CellClick += gridProtestos_CellClick;
            }
            else
            {
                MessageBox.Show("Nenhum protesto encontrado na base!");
            }
        }

        private void gridProtestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProtesto = 0;
            
            if (e.ColumnIndex == gridProtestos.Columns["btnEditar"].Index)
            {
                frmEdtProtesto frmEdtProtesto = new frmEdtProtesto(this);
                DataGridViewRow row = gridProtestos.Rows[e.RowIndex];
                idProtesto = Convert.ToInt32(row.Cells["protestoId"].Value);
                frmEdtProtesto.idProtesto = idProtesto;
                frmEdtProtesto.Show();
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txtNroProtesto.Text != null)
            {
                LocalizarProtesto(txtNroProtesto.Text);
            }
            else
            {
                MessageBox.Show("Preenchar com o número do protesto que deseja localizar!");
            }
        }

        private void LocalizarProtesto(string text)
        {
            throw new NotImplementedException();
        }
    }
}
