using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntercambioRecursos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void EventoClickBuscarImagen(object sender, EventArgs e)
        {
            // PRIMER EVENTO CREADO DESDE EL FORMULARIO 2.

            // AQUÍ SE ABRE UN NUEVO ARCHIVO DE TEXTO ESCRITO A MODO DE DIÁLOGO...

            OpenFileDialog archivoDialogo = new OpenFileDialog();

            // LAS EXTENSIONES DE UN ARCHIVO TIENEN QUE SER VÁLIDOS ACORDE A LOS FORMATOS COMPATIBLES QUE SUBES MEDIANTE UN DIÁLOGO DEL ARCHIVO ESCRITO...

            archivoDialogo.Filter = " Sólo se permiten imágenes mediante extensiones disponibles aquí | *.jpg; *.jpeg; *.png; *.gif";

            // SI EL ARCHIVO SUBIDO CORRESPONDE AL FORMATO DEL MISMO ARCHIVO QUE ESCRIBISTE, ENTONCES SE MUESTRA UN TEXTO DESCRIPTIVO DEBAJO DE LA IMAGEN MÁS SU EXTENSIÓN APROPIADA.

            if (archivoDialogo.ShowDialog() == DialogResult.OK)
            {
                nombreArchivoElegido.Text = Path.GetFullPath(archivoDialogo.FileName);
            }
        }

        private void EventoClickEnvioRecibido(object sender, EventArgs e)
        {
            // SEGUNDO EVENTO CREADO DESDE EL FORMULARIO 2.

            // CON ESTE EVENTO SOLAMENTE SE PUEDE EJECUTAR UNA SOLA LÍNEA DE CÓDIGO AL ELEGIR UN ARCHIVO EXISTENTE A TRAVÉS DE UNA CASILLA DE NOMBRE DEL DIRECTORIO ELEGIDO...

            Form1.nombreArchivo = nombreArchivoElegido.Text;
        }
    }
}
