namespace PreparacionClase
{
    partial class Form2
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
            btnSync = new Button();
            btnAsync = new Button();
            lblEstado = new Label();
            lblCafe = new Label();
            lblTostadas = new Label();
            lblJugo = new Label();
            SuspendLayout();
            // 
            // btnSync
            // 
            btnSync.Location = new Point(171, 55);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(114, 37);
            btnSync.TabIndex = 0;
            btnSync.Text = "PrepararSincrono";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // btnAsync
            // 
            btnAsync.Location = new Point(340, 55);
            btnAsync.Name = "btnAsync";
            btnAsync.Size = new Size(104, 36);
            btnAsync.TabIndex = 1;
            btnAsync.Text = "Preparar Async";
            btnAsync.UseVisualStyleBackColor = true;
            btnAsync.Click += btnAsync_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(478, 66);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(71, 15);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Esperando...";
            // 
            // lblCafe
            // 
            lblCafe.AutoSize = true;
            lblCafe.Location = new Point(478, 134);
            lblCafe.Name = "lblCafe";
            lblCafe.Size = new Size(46, 15);
            lblCafe.TabIndex = 3;
            lblCafe.Text = "Cafe:❌";
            // 
            // lblTostadas
            // 
            lblTostadas.AutoSize = true;
            lblTostadas.Location = new Point(470, 197);
            lblTostadas.Name = "lblTostadas";
            lblTostadas.Size = new Size(67, 15);
            lblTostadas.TabIndex = 4;
            lblTostadas.Text = "Tostadas:❌";
            // 
            // lblJugo
            // 
            lblJugo.AutoSize = true;
            lblJugo.Location = new Point(478, 246);
            lblJugo.Name = "lblJugo";
            lblJugo.Size = new Size(47, 15);
            lblJugo.TabIndex = 5;
            lblJugo.Text = "Jugo:❌";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblJugo);
            Controls.Add(lblTostadas);
            Controls.Add(lblCafe);
            Controls.Add(lblEstado);
            Controls.Add(btnAsync);
            Controls.Add(btnSync);
            Name = "Form2";
            Text = "Formulario2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSync;
        private Button btnAsync;
        private Label lblEstado;
        private Label lblCafe;
        private Label lblTostadas;
        private Label lblJugo;
    }
}