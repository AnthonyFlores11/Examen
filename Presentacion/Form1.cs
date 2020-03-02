using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int conta = 0;
        OPPersona Oper = new OPPersona();
        List<Persona> listaP = new List<Persona>();
        OperacionTelefono OTel = new OperacionTelefono();
        
        
        private void btAgregar_Click(object sender, EventArgs e)
        {
            
            if(texID.TextLength == 0)
            {
                MessageBox.Show("Se deben de completar todos los campos");
            }
            else
            {
                if(txnombre.TextLength == 0)
                {
                    MessageBox.Show("Se deben de completar todos los campos");
                }
                else
                {
                    if(texApellido.TextLength == 0)
                    {
                        MessageBox.Show("Se deben de completar todos los campos");
                    }
                    else
                    {
                        if (textEmail.TextLength == 0)
                        {
                            MessageBox.Show("Se deben de completar todos los campos");
                        }
                        else
                        {
                            if (texCedula.TextLength == 0)
                            {
                                MessageBox.Show("Se deben de completar todos los campos");
                            }
                            else
                            {
                                Persona persona = new Persona(int.Parse(texID.Text), txnombre.Text, textEmail.Text, texCedula.Text, texApellido.Text);
                                Oper.Insertar(persona);
                                listaP = Oper.MostrarTodo();
                                DatosTabla(listaP);
                               

                                LimpiarCampos();
                                if (listaP!=null){

                                    MessageBox.Show("Agregado correctamente");

                                }
                                
                               
                            }
                        }
                    }
                }
            }
        }
        public void DatosTabla(List<Persona> persona)
        {
            DGVPersona.DataSource = persona;
        }
        
        public void LimpiarCampos()
        {
            texApellido.Text = "";
            texCedula.Text = "";
            texID.Text = "";
            txnombre.Text = "";
            textEmail.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btAgregarTel_Click(object sender, EventArgs e)
        {
            if(textTel.TextLength == 0)
            {
                MessageBox.Show("Ingrese el numero de telefono");
            }
            else
            {
                if (comboBoxTel.SelectedItem.Equals("Seleccione"))
                {
                    MessageBox.Show("Seleccione una opcion");
                }
                else
                {
                    if(texDescrip.TextLength == 0)
                    {
                        MessageBox.Show("Ingrese una descripcion del telefono");
                    }
                    else
                    {
                      //  Telefono cel = new Celular()

                    }
                }
            }
        }
        public void TablaDatos(List<Persona> persona)
        {

        }

        private void DGVPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int poc = DGVPersona.CurrentRow.Index;
            txnombre.Text = DGVPersona.CurrentRow.ToString();
            texApellido.Text = DGVPersona.CurrentRow.ToString();
            texCedula.Text = DGVPersona.CurrentRow.ToString();
            texID.Text = DGVPersona.CurrentRow.ToString();
            textEmail.Text = DGVPersona.CurrentRow.ToString();
            
        }
    }
}
