using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreparacionClase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void HacerCafe()
        {
            Thread.Sleep(5000);
        }
        private void TostarPan()
        {
            Thread.Sleep(5000);
        }
        private void ExprimirJugo()
        {
            Thread.Sleep(5000);
        }

        private async Task HacerCafeAsync()
        {
            await Task.Delay(5000); // Simula 5 segundos de espera sin bloquear
            Console.WriteLine("Café hecho.");
        }

        private async Task TostarPanAsync()
        {
            await Task.Delay(5000);
            Console.WriteLine("Pan tostado.");
        }

        private async Task ExprimirJugoAsync()
        {
            await Task.Delay(5000);
            Console.WriteLine("Jugo exprimido.");
        }


        private void EjSincrono_Load(object sender, EventArgs e)
        {

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Iniciando Desayuno bloqueante ....";
            Refresh();

            lblCafe.Text = "Haciendo Cafe";
            Refresh();
            HacerCafe();
            lblCafe.Text = "Cafe Listo";
            Refresh();

            lblTostadas.Text = "Haciendo Tostadas";
            Refresh();
            TostarPan();
            lblTostadas.Text = "Tostada Lista";
            Refresh();

            lblJugo.Text = "Haciendo Cafe";
            Refresh();
            ExprimirJugo();
            lblJugo.Text = "Jugo Listo";
            Refresh();


            lblEstado.Text = "Desayuno LIsto!!";
            Refresh();
        }


        private async void btnAsync_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Inciando Asincrono";
            Refresh();

            var taskCafe = HacerCafeAsync();
            var taskTostadas = TostarPanAsync();
            var taskJugo = ExprimirJugoAsync();

            lblCafe.Text = "Haciendo Cafe";
            lblTostadas.Text = "Haciendo Tostadas";
            lblJugo.Text = "Haciendo Jugo";
           
            await Task.WhenAll(taskCafe,taskTostadas, taskJugo);

            lblEstado.Text = "Desayuno Listo en modo Async!";

            lblCafe.Text = "Cafe listo";
            lblTostadas.Text = "Tostadas listo";
            lblJugo.Text = "Jugo listo";


        }
    }
}
