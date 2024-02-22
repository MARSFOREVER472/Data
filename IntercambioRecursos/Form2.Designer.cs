namespace IntercambioRecursos
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
            botonBuscarImagen = new Button();
            botonEnvio = new Button();
            nombreArchivoElegido = new TextBox();
            SuspendLayout();
            // 
            // botonBuscarImagen
            // 
            botonBuscarImagen.BackColor = Color.FromArgb(255, 128, 0);
            botonBuscarImagen.Location = new Point(12, 12);
            botonBuscarImagen.Name = "botonBuscarImagen";
            botonBuscarImagen.Size = new Size(174, 34);
            botonBuscarImagen.TabIndex = 0;
            botonBuscarImagen.Text = "Buscar en el PC";
            botonBuscarImagen.UseVisualStyleBackColor = false;
            botonBuscarImagen.Click += EventoClickBuscarImagen;
            // 
            // botonEnvio
            // 
            botonEnvio.BackColor = Color.Red;
            botonEnvio.DialogResult = DialogResult.OK;
            botonEnvio.Location = new Point(12, 89);
            botonEnvio.Name = "botonEnvio";
            botonEnvio.Size = new Size(112, 34);
            botonEnvio.TabIndex = 1;
            botonEnvio.Text = "Enviar";
            botonEnvio.UseVisualStyleBackColor = false;
            botonEnvio.Click += EventoClickEnvioRecibido;
            // 
            // nombreArchivoElegido
            // 
            nombreArchivoElegido.BackColor = Color.Yellow;
            nombreArchivoElegido.Location = new Point(12, 52);
            nombreArchivoElegido.Name = "nombreArchivoElegido";
            nombreArchivoElegido.Size = new Size(400, 31);
            nombreArchivoElegido.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 144);
            Controls.Add(nombreArchivoElegido);
            Controls.Add(botonEnvio);
            Controls.Add(botonBuscarImagen);
            Name = "Form2";
            Text = "Elegir una imagen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonBuscarImagen;
        private Button botonEnvio;
        private TextBox nombreArchivoElegido;
    }
}