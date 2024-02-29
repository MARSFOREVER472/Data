namespace IntercambioRecursos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botonAnadirImagen = new Button();
            nombreDirectorio = new Label();
            imagenRecursos = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagenRecursos).BeginInit();
            SuspendLayout();
            // 
            // botonAnadirImagen
            // 
            botonAnadirImagen.BackColor = Color.Red;
            botonAnadirImagen.Location = new Point(150, 400);
            botonAnadirImagen.Name = "botonAnadirImagen";
            botonAnadirImagen.Size = new Size(150, 34);
            botonAnadirImagen.TabIndex = 0;
            botonAnadirImagen.Text = "Añadir imagen";
            botonAnadirImagen.UseVisualStyleBackColor = false;
            botonAnadirImagen.Click += EventoClickAgregarImagen;
            // 
            // nombreDirectorio
            // 
            nombreDirectorio.AutoSize = true;
            nombreDirectorio.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            nombreDirectorio.Location = new Point(70, 365);
            nombreDirectorio.Name = "nombreDirectorio";
            nombreDirectorio.Size = new Size(52, 21);
            nombreDirectorio.TabIndex = 1;
            nombreDirectorio.Text = "label1";
            // 
            // imagenRecursos
            // 
            imagenRecursos.Location = new Point(10, 10);
            imagenRecursos.Name = "imagenRecursos";
            imagenRecursos.Size = new Size(456, 347);
            imagenRecursos.SizeMode = PictureBoxSizeMode.CenterImage;
            imagenRecursos.TabIndex = 2;
            imagenRecursos.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(478, 450);
            Controls.Add(imagenRecursos);
            Controls.Add(nombreDirectorio);
            Controls.Add(botonAnadirImagen);
            Name = "Form1";
            Text = "Intercambiar recursos";
            ((System.ComponentModel.ISupportInitialize)imagenRecursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonAnadirImagen;
        private Label nombreDirectorio;
        private PictureBox imagenRecursos;
    }
}