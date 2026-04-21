using Clase2.Entidad;

namespace Clase2.FrontForm
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string tipoLicencia = txtTipoLicencia.Text;
            string nombreEmpleado = txtEmpleado.Text;
            string area = cbxDepartamento.SelectedItem.ToString();
            string cantidadDias = cbxDiasSolicitados.SelectedItem.ToString();

            Licencia licencia = new Licencia
            {
                TipoLicencia = tipoLicencia,
                NombreEmpleado = nombreEmpleado,
                Area = area,
                CantidadDias = cantidadDias
            };

            enviarResultadoApi(licencia);



            limpiarControles();
        }

        private void cargarGrilla(Licencia licencia)
        {
            dgvlicencias.Rows.Add(licencia.TipoLicencia, licencia.NombreEmpleado, licencia.Area, licencia.CantidadDias);
        }

        private void limpiarControles()
        {
            txtTipoLicencia.Clear();
            txtEmpleado.Clear();
            cbxDepartamento.SelectedIndex = -1;
            cbxDiasSolicitados.SelectedIndex = -1;


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            obtenerResultadosApi();
        }

        //obtener resultados de la api

        private async Task obtenerResultadosApi()
        {
            using (HttpClient client = new HttpClient())
            {
               try
                {
                    var response = await client.GetAsync("https://localhost:7044/api/licencias");
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                       var licencias = System.Text.Json.JsonSerializer.Deserialize<List<Licencia>>(jsonResponse, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                        dgvlicencias.Rows.Clear();

                        foreach (var licencia in licencias)
                        {
                            cargarGrilla(licencia);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener datos de la API");
                    }
                } catch (HttpRequestException ex) {    
                        MessageBox.Show("Error al obtener datos de la API: " + ex.Message);     
                    }
            }

        }

        private async Task enviarResultadoApi(Licencia licencia)
        {
            using(HttpClient client = new HttpClient()) {
                try
                {
                    var jsonContent = System.Text.Json.JsonSerializer.Serialize(licencia);
                    var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://localhost:7044/api/licencias", content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Licencia registrada exitosamente en la API");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar licencia en la API");
                    }

                }
                catch (HttpRequestException ex) {
                        MessageBox.Show("Error al registrar licencia en la API: " + ex.Message);
            }
        }
    }
}
