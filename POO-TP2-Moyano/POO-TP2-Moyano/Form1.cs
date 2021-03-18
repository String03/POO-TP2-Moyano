
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using POO_TP2_Moyano.Modelos;
using POO_TP2_Moyano.Modelos.EventsArgs;

namespace POO_TP2_Moyano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Lista de contenedores que va en la grilla 1

        private List<Contenedor> Contenedores;

        //Lista de clientes que va en la grilla 2
        private List<Cliente> Clientes;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Contenedores = new List<Contenedor>();
            Clientes = new List<Cliente>();

        }


        //Botón para agregar contenedor

        private void btn_agregar_contenedor_Click(object sender, EventArgs e)
        {


            try
            {
                Cliente cliente;

                try
                {
                    cliente = (Cliente)this.dataGridView2.SelectedRows[0].DataBoundItem;
                }
                catch
                {
                    throw new Exception("Debe elegir un cliente");
                }

                if (!txt_id_contenedor.MaskCompleted) throw new Exception("Id no válido ");
                Contenedor CO;
                if (rdo_contenedor_a.Checked)
                {

                    CO = new ContenedorA(txt_id_contenedor.Text.Trim(),
                      txt_descripcion_contenedor.Text.Trim(), DateTime.ParseExact
                      (txt_fecha_ingreso_contenedor.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture), decimal.Parse(txt_peso_contenedor.Text.Trim()));
                }
                else
                {
                    CO = new ContenedorB(txt_id_contenedor.Text.Trim(),
                 txt_descripcion_contenedor.Text.Trim(), DateTime.ParseExact
                 (txt_fecha_ingreso_contenedor.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture), decimal.Parse(txt_peso_contenedor.Text.Trim()));
                }
                CO.SuperiorA4000 += (o, s) =>
                {
                    MessageBox.Show(this, "Id : " + s.Legajo + "\nDescripción:" + s.Descripcion + "\nLegajo del cliente " + s.Cliente.Legajo + "\n" + (s.Cliente.GetType() == typeof(Persona) ?
"Nombre y Apellido:" + s.Cliente.Nombre + " " + s.Cliente.Apellido : "Razón social: " + s.Cliente.RazonSocial));
                };

                if (Contenedores.Any(c => c.Id.ToUpper() == CO.Id.ToUpper()))
                    throw new Exception("Contenedor repetido");

                CO.AsociarCliente(cliente);
                cliente.Contenedores.Add(CO);
                Contenedores.Add(CO);
                CO.Peso = CO.Peso;
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = Contenedores;
                this.dataGridView3.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos de entrada: " + ex.Message);
            }
        }

        //Botón para agregar un cliente

        private void btn_agregar_cliente_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente Cli;

                if (rdo_personas.Checked)
                {
                    Cli = new Persona(txt_legajo_cliente_persona.Text.Trim(), txt_nombre_cliente.Text.Trim(), txt_apellido_cliente.Text.Trim());
                }
                else { Cli = new Empresa(txt_legajo_cliente_empresa.Text.Trim(), txt_cliente_razon_social.Text.Trim()); }
                if (Clientes.Any(c => c.Legajo.ToUpper() == Cli.Legajo.ToUpper()))
                    throw new Exception("Cliente repetido");
                Clientes.Add(Cli);
                this.dataGridView2.DataSource = null;
                this.dataGridView2.DataSource = Clientes;
                this.dataGridView3.DataSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos de entrada" + ex.Message);
            }



        }

        private void rdo_personas_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_cliente_razon_social.Enabled = !this.rdo_personas.Checked;
            this.txt_legajo_cliente_empresa.Enabled = !this.rdo_personas.Checked;
            this.txt_legajo_cliente_persona.Enabled = this.rdo_personas.Checked;
            this.txt_nombre_cliente.Enabled = this.rdo_personas.Checked;
            this.txt_apellido_cliente.Enabled = this.rdo_personas.Checked;
        }

        //Botón para eliminar un contenedor

        private void btn_eliminar_contenedor_Click(object sender, EventArgs e)
        {
            try
            {
                Contenedor contenedor = (Contenedor)this.dataGridView1.SelectedRows[0].DataBoundItem;
                contenedor.ObtenerCliente().Contenedores.Remove(contenedor);
                this.Contenedores.Remove(contenedor);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = Contenedores;
                this.dataGridView3.DataSource = null;

            }
            catch
            {
                MessageBox.Show(this, "debe elegir un contenedor");
            }
        }
        //Botón para eliminar un cliente
        private void btn_eliminar_cliente_Click(object sender, EventArgs e)
        {
            try
            {

                Cliente cliente = (Cliente)this.dataGridView2.SelectedRows[0].DataBoundItem;
                cliente.Contenedores.ForEach(C => this.Contenedores.Remove(C));
                this.Clientes.Remove(cliente);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = Contenedores;
                this.dataGridView2.DataSource = null;
                this.dataGridView2.DataSource = Clientes;
                this.dataGridView3.DataSource = null;
            }
            catch
            {
                MessageBox.Show(this, "debe elegir un cliente");
            }

        }
        //Botón para modificar un contenedor
        private void btn_modificar_contenedor_Click(object sender, EventArgs e)
        {
            try
            {
                Contenedor contenedor = (Contenedor)this.dataGridView1.SelectedRows[0].DataBoundItem;
                contenedor.Descripcion = txt_descripcion_contenedor.Text;
                contenedor.Fechaingreso = DateTime.ParseExact(txt_fecha_ingreso_contenedor.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                contenedor.Peso = Decimal.Parse(txt_peso_contenedor.Text);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = Contenedores;
                this.dataGridView3.DataSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "no se pudo modificar: " + ex.Message);
            }
        }
        //Botón para modificar un cliente
        private void btn_modificar_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)this.dataGridView2.SelectedRows[0].DataBoundItem;
                if (rdo_personas.Checked)
                {
                    if (cliente.GetType() == typeof(Empresa))
                        throw new Exception("no es una persona");
                    cliente.RazonSocial = null;
                    cliente.Nombre = txt_nombre_cliente.Text;
                    cliente.Apellido = txt_apellido_cliente.Text;


                }

                else
                {
                    if (cliente.GetType() == typeof(Persona))
                        throw new Exception("no es una empresa");
                    cliente.RazonSocial = txt_cliente_razon_social.Text;
                    cliente.Nombre = null;
                    cliente.Apellido = null;


                }

                this.dataGridView2.DataSource = null;
                this.dataGridView2.DataSource = Clientes;
                this.dataGridView3.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "no se pudo modificar: " + ex.Message);
            }
        }
        //Botón para mostrar contenedores
        private void btn_mostrar_contenedores_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)this.dataGridView2.SelectedRows[0].DataBoundItem;
                this.dataGridView3.DataSource = null;
                this.dataGridView3.DataSource = cliente.Contenedores.Select(C => new
                {
                    Id = C.Id,
                    Descripcion = C.Descripcion,
                    FechaIngreso = C.Fechaingreso,
                    Peso = C.Peso,
                    Cliente = C.ObtenerCliente().ToString()
                }).ToList();
            }
            catch
            {
                MessageBox.Show(this, "debe seleccionar un cliente");
            }
        }
    }
}
