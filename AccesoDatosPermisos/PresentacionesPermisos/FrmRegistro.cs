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
    public partial class FrmRegistro : Form
    {
        private Usuarios usuario;
        private ManejadoresUsuarios _manejaUsuario;

        
        public string banderaGuardar;
        public FrmRegistro()
        {
            InitializeComponent();
            usuario = new Usuarios();
            _manejaUsuario = new ManejadoresUsuarios();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar == "guardar")
            {
                GuardarUsuario();
                Close();
            }
            else
            {
                ActualizarUsuario();
                Close();
            }
            
        }

        private void GuardarUsuario()
        {
            usuario.Idusuarios = 0;
            usuario.Nombre = txtNombre.Text;
            usuario.Apellidop = txtApellidop.Text;
            usuario.Apellidom = txtApellidom.Text;
            usuario.Fechanacimiento = txtFecha.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Rfc = txtRFC.Text;
            usuario.Fkidaccesos = "Usuario";

            var valida = _manejaUsuario.ValidarUsuarios(usuario);

            if (valida.Item1)
            {
                _manejaUsuario.GuardarUsuarios(usuario);
            }

            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }


        private void ActualizarUsuario()
        {
            _manejaUsuario.ActualizarUsuarios(new Usuarios
            {
                Idusuarios = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Apellidop = txtApellidop.Text,
                Apellidom = txtApellidom.Text,
                Fechanacimiento = txtFecha.Text,
                Rfc = txtRFC.Text,
                Contraseña = txtContraseña.Text,
                Fkidaccesos = cmbEstado.Text
            });
        }
    }
}
