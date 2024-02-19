namespace IntercambioRecursos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EventoClickAgregarImagen(object sender, EventArgs e)
        {
            // EVENTO CREADO DESDE EL FORMULARIO 1.

            // VINCULAREMOS AL OTRO FORMULARIO YA CREADO EN EL PROYECTO...

            Form2 nuevoFormulario = new Form2();

            nuevoFormulario.ShowDialog(); // LLAMAREMOS AL MÉTODO JUNTO CON LA VARIABLE PARA MOSTRAR LA LÍNEA DE CÓDIGO YA CREADO ANTERIORMENTE.
        }
    }
}