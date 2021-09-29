﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPermisos;
using ManejadoresPermisos;

namespace PresentacionesPermisos
{
    public partial class FrmLogin : Form
    {
        public static ManejadoresUsuarios _usuariosManejador;
        private Usuarios _usuarios;
        public FrmLogin()
        {
            InitializeComponent();
            _usuariosManejador = new ManejadoresUsuarios();
            _usuarios = new Usuarios();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            _usuarios.Nombre = txtUsuario.Text;
            _usuarios.Contraseña = txtContraseña.Text;
            if (_usuariosManejador.ExisteUsuario(_usuarios))
            {
                if (txtUsuario.Text == "Alberto" && txtContraseña.Text == "Hola")
                {
                    FrmMenu formmenu = new FrmMenu();
                    formmenu.Show();
                    this.Hide();

                    MessageBox.Show("bienvenido administrador");
                    formmenu.lblTipoCuenta.Text = "Administrador";
                }

                else 
                {
                    FrmMenu formmenu = new FrmMenu();
                    formmenu.Show();
                    this.Hide();
                    formmenu.btnUsuarios.Visible = false;
                    formmenu.lblUsuario.Visible = false;
                   

                    MessageBox.Show("Bienvenido " + txtUsuario.Text + ", tienes permisos restringidos");
                    formmenu.lblTipoCuenta.Text = "Usuario";
                }


            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            FrmMenu formmenu = new FrmMenu();
            formmenu.Show();
            this.Hide();
            formmenu.toolStrip1.Enabled = false;
            formmenu.btnSalir.Enabled = true;

            
            MessageBox.Show("No puedes acceder al contenido de este formulario");
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            FrmRegistro fr = new FrmRegistro();
            fr.banderaGuardar = "guardar";
            fr.ShowDialog();
            
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
