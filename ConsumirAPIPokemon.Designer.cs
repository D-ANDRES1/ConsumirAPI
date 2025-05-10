///designer
using System.Runtime.CompilerServices;

namespace PreparacionClase
{
    partial class ConsumirAPIPokemon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblPeso = new Label();
            lblAltura = new Label();
            pictureBox1 = new PictureBox();
            btnConsulta = new Button();
            lblTipo = new Label();
            dataGridViewStats = new DataGridView();
            btnGuardarPokemon = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Pokemon GB", 7F);
            txtNombre.Location = new Point(131, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 17);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Pokemon GB", 7F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(27, 77);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 11);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Pokemon GB", 7F);
            lblPeso.ForeColor = Color.White;
            lblPeso.Location = new Point(27, 132);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(45, 11);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Pokemon GB", 7F);
            lblAltura.ForeColor = Color.White;
            lblAltura.Location = new Point(27, 164);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(65, 11);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "Altura";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(342, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 98);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnConsulta
            // 
            btnConsulta.Font = new Font("Pokemon GB", 7F);
            btnConsulta.Location = new Point(354, 24);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(108, 26);
            btnConsulta.TabIndex = 5;
            btnConsulta.Text = "Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnBuscarPokemon_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Pokemon GB", 7F);
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(27, 105);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(45, 11);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo";
            // 
            // dataGridViewStats
            // 
            dataGridViewStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStats.Font = new Font("Pokemon GB", 6F);
            dataGridViewStats.Location = new Point(27, 199);
            dataGridViewStats.Name = "dataGridViewStats";
            dataGridViewStats.Size = new Size(256, 176);
            dataGridViewStats.TabIndex = 7;
            // 
            // btnGuardarPokemon
            // 
            btnGuardarPokemon.Font = new Font("Pokemon GB", 6F);
            btnGuardarPokemon.Location = new Point(342, 203);
            btnGuardarPokemon.Name = "btnGuardarPokemon";
            btnGuardarPokemon.Size = new Size(120, 22);
            btnGuardarPokemon.TabIndex = 8;
            btnGuardarPokemon.Text = "Guardar json";
            btnGuardarPokemon.UseVisualStyleBackColor = true;
            btnGuardarPokemon.Click += btnGuardarPokemon_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(13, 29);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 21);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(487, 388);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardarPokemon);
            Controls.Add(dataGridViewStats);
            Controls.Add(lblTipo);
            Controls.Add(btnConsulta);
            Controls.Add(pictureBox1);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "Form3";
            Padding = new Padding(10);
            Text = "Pokedex";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblPeso;
        private Label lblAltura;
        private PictureBox pictureBox1;
        private Button btnConsulta;
        private Label lblTipo;
        private DataGridView dataGridViewStats;
        private Button btnGuardarPokemon;
        private Button btnLimpiar;
    }
}
//