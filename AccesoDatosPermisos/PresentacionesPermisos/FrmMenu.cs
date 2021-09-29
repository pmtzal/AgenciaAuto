﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionesPermisos
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (lblTipoCuenta.Text == "Administrador")
            {
                FrmVistasUsuarios fvu = new FrmVistasUsuarios();
                fvu.ShowDialog();
                
            }

            else if (lblTipoCuenta.Text == "Usuario")
            {
                FrmVistasUsuarios fvu = new FrmVistasUsuarios();
                fvu.btnAgregar.Visible = false;
                fvu.btnEliminar.Visible = false;
                fvu.dtgUsuarios.Enabled = false;
                fvu.ShowDialog();

                
            }
            
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            

            if(lblTipoCuenta.Text == "Usuario")
            {
                FrmVistasHerramientas fv = new FrmVistasHerramientas();
                fv.btnEliminar.Visible = false;
                fv.dtgHerramientas.Enabled = false;
                fv.ShowDialog();
                
            }

            else
            {
                FrmVistasHerramientas fv = new FrmVistasHerramientas();
                fv.ShowDialog();
            }

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (lblTipoCuenta.Text == "Usuario")
            {
                FrmVistasProductos fv = new FrmVistasProductos();
                fv.btnEliminar.Visible = false;
                fv.dtgProductos.Enabled = false;
                fv.ShowDialog();
            }

            else
            {
                FrmVistasProductos fv = new FrmVistasProductos();
               
                fv.ShowDialog();
            }
            
        }
    }
}
