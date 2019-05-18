﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaGaleras
{
    public partial class QuejasSugerencias : Form
    {
        ArrayList inventario;
        int[] cantidades = new int[3];

        public QuejasSugerencias(ArrayList inventario, int[] cantidades)
        {
            InitializeComponent();
            this.cantidades = cantidades;
            this.inventario = inventario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (inventario.Count != 0)
            if (cboTipoRecurso.SelectedItem.ToString() == "Felicitación")
                {
                    cantidades[0] = cantidades[0] + 1;
                }

            MDIFarmacia form = new MDIFarmacia(inventario, cantidades);
            form.Show();
            this.Hide();
        {
            if (txtNombresCompletos.Text != "" && txtIdentificacion.Text != "" && txtTelefono.Text != "" &&
                txtBarrio.Text != "" && txtEmail.Text != "" && cboTipoRecurso.Text != "" &&
                dtpFecha.Text != "" && txtSituacionPresentada.Text != "" && lblFelicitaciones.Text != "")


                MessageBox.Show("Los campos señalados con * son obligatorias, Por favor diligenciar todos para poder continuar", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MDIFarmacia form = new MDIFarmacia(inventario, cantidades);
            form.Show();
            this.Hide();
        }

        private void QuejasSugerencias_Load(object sender, EventArgs e)
        {
            lblFelicitaciones.Text = cantidades[0].ToString();
        }

        private void lblNumeroDeFelicitaciones_Click(object sender, EventArgs e)
        {


        }
    }
}
