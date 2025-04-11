using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace Semana13
{
    public partial class frmToken : Form
    {
        public frmToken()
        {
            InitializeComponent();
        }

        private void frmToken_Load(object sender, EventArgs e)
        {
            var clienteRest = new RestClient(Constantes.URI_TOKEN);
            var request = new RestRequest("", Method.Post); // Fix: Add empty  as the first parameter

            request.AddHeader("Content-Type", Constantes.CONTENT_TYPE);
            request.AddParameter("grant_type", Constantes.GRANT_TYPE);
            request.AddParameter("scope", Constantes.SCOPE);
            request.AddParameter("client_id", Constantes.CLIENT_ID);
            request.AddParameter("client_secret", Constantes.CLIENT_SECRET);

            RestResponse restResponseToken = clienteRest.Execute(request);
            txtResponse.Text = restResponseToken.Content;

            if (restResponseToken.IsSuccessful)
            {
                var jsonResponseToken = JsonSerializer.Deserialize<JsonResponseToken>(restResponseToken.Content);
                txtToken.Text = jsonResponseToken.access_token;
            }
            else
            {
                MessageBox.Show("Error al obtener el token: " + restResponseToken.ErrorMessage);
            }
        }
    }
}

