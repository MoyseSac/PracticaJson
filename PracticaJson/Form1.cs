using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaJson
{
    public partial class Form1 : Form
    {
        List<int> notasTemp = new List<int>();
        List<Notas> listaNotas = new List<Notas>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarNota_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt16(textNota.Text);
            notasTemp.Add(nota);
            textNota.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guardarTexto() {

            string json = JsonConvert.SerializeObject(listaNotas);
            string archivo = "Datos.Json";
            System.IO.File.WriteAllText(archivo,json);
        
        }
        private void buttonGuardarAlumno_Click(object sender, EventArgs e)
        {
            Notas notasAlumno = new Notas();
            notasAlumno.Nombre = textNombre.Text;
            notasAlumno.Notes = notasTemp;
            listaNotas.Add(notasAlumno);
            guardarTexto();
            notasTemp.Clear();
            
            
        }
    }
}
