
///form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace PreparacionClase
{
    public partial class ConsumirAPIPokemon : Form
    {
        private HttpClient client = new HttpClient();
        public ConsumirAPIPokemon()
        {
            InitializeComponent();
        }

        private async void btnBuscarPokemon_Click(object sender, EventArgs e) // con Task en vez de void no me funciona
        {
            string pokemonName = txtNombre.Text.ToLower();

            if (string.IsNullOrWhiteSpace(pokemonName))
            {
                MessageBox.Show("Por favor, ingresa el nombre de un Pokémon o numero de este.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";

            try
            {
                string response = await client.GetStringAsync(url);
                JObject data = JObject.Parse(response); // desearializar json

                lblNombre.Text = data["name"].ToString();

                var tipos = data["types"]
                .Select(t => t["type"]["name"].ToString())  // para cada t, devolvemos t["type"]["name"].ToString()
                .ToList();

                lblTipo.Text = $"Tipo(s): {string.Join(", ", tipos)}";

                lblPeso.Text = $"Peso: {data["weight"]}";
                lblAltura.Text = $"Altura: {data["height"]}";
                string imagenUrl = data["sprites"]["front_default"].ToString();
                pictureBox1.Load(imagenUrl);

                var stats = data["stats"]
            .Select(s => new
            {
                Estadística = s["stat"]["name"].ToString(),
                Valor = (int)s["base_stat"]
            })
            .ToList();

                dataGridViewStats.DataSource = stats;
                dataGridViewStats.Columns["Estadística"].HeaderText = "Estadística";
                dataGridViewStats.Columns["Valor"].HeaderText = "Valor";
                var colEstadistica = dataGridViewStats.Columns["Estadística"];
                colEstadistica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Pokemon no encontrado: " + ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private async void btnGuardarPokemon_Click(object sender, EventArgs e)
        {
            string pokemonName = txtNombre.Text.ToLower();


            if (string.IsNullOrWhiteSpace(pokemonName))
            {
                MessageBox.Show("Por favor, ingresa el nombre de un Pokémon o numero de este.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";

            try
            {
                string response = await client.GetStringAsync(url);

                string documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                JObject data = JObject.Parse(response);
                string nombrePokemon = data["name"].ToString();

                string rutaArchivo = Path.Combine(documentos, $"{nombrePokemon}.json");

                await File.WriteAllTextAsync(rutaArchivo, response);

                MessageBox.Show($"Se ha guardado un archivo {nombrePokemon}.json En la ruta" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el documento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNombre.Focus();
        }
    }
}
