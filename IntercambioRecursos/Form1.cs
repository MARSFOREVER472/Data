namespace IntercambioRecursos
{
    public partial class Form1 : Form
    {
        // CREAREMOS UN NUEVA VARIABLE AL ARCHIVO POR DEFECTO DE MANERA ESTÁTICA AQUÍ...

        public static string nombreArchivo = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void EventoClickAgregarImagen(object sender, EventArgs e)
        {
            // EVENTO CREADO DESDE EL FORMULARIO 1.

            // VINCULAREMOS AL OTRO FORMULARIO YA CREADO EN EL PROYECTO...

            Form2 nuevoFormulario = new Form2();

            DialogResult resultado = nuevoFormulario.ShowDialog(); // LLAMAREMOS AL MÉTODO JUNTO CON LA VARIABLE PARA MOSTRAR LA LÍNEA DE CÓDIGO YA CREADO ANTERIORMENTE.

            if (resultado == DialogResult.OK) // SI EL RESULTADO ESPERADO CUMPLE CON ESTA CONDICIÓN...
            {
                nombreDirectorio.Text = nombreArchivo; // EL NOMBRE DEL DIRECTORIO SE MUESTRA EN EL PRIMER FORMULARIO.
            }
        }
    }
}