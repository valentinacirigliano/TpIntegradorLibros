﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpIntegradorLibros.Entidades;
using TpIntegradorLibros.Datos;
using Editorial = TpIntegradorLibros.Entidades.Editorial;
using Tema = TpIntegradorLibros.Entidades.Tema;

namespace TpIntegradorLibros.Windows
{
    public partial class FrmLibroPrincipal : Form
    {
        public FrmLibroPrincipal()
        {
            InitializeComponent();
        }

        public List<Libro> lista;
        private int cantidadRegistros;

        private void FrmLibroPrincipal_Load(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().GetLista();
            MostrarCantidadRegistors();
            if (cantidadRegistros > 0)
            {
                MostrarDatosEnGrilla();
            }
        }



        private void MostrarCantidadRegistors()
        {
            cantidadRegistros = RepositorioDeLibros.GetInstancia().GetCantidad();
            CantidadRegistrosLabel.Text = cantidadRegistros.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var libro in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, libro);
                AgregarFila(r);
            }
        }

        
        private void SetearFila(DataGridViewRow r, Libro libro)
        {
            r.Cells[colNombre.Index].Value = libro.NombreDelLibro;
            r.Cells[colEditorial.Index].Value = libro.Editorial;
            r.Cells[colTema.Index].Value = libro.Tema;
            r.Cells[colPaginas.Index].Value = libro.Paginas;
            r.Cells[colISBN.Index].Value = libro.ISBN;
            r.Cells[colAutor.Index].Value = libro.Autor;

            r.Tag = libro; 
        }
        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }
        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }
        private void SalirTSB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NuevoTSB_Click(object sender, EventArgs e)
        {
            //capturar los datos
            FrmLibroAE frm = new FrmLibroAE() { Text = "Agregar libro" };
            DialogResult dr = frm.ShowDialog(this);
            //ver si ya no existe
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            Libro libr = frm.GetLibro();
            if (RepositorioDeLibros.GetInstancia().Existe(libr))
            {
                MessageBox.Show("Libro existente!!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //si no existe lo guardo
            RepositorioDeLibros.GetInstancia().Agregar(libr);
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, libr);
            AgregarFila(r);
            MostrarCantidadRegistors();
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            lista = RepositorioDeLibros.GetInstancia().GetLista();
            MostrarDatosEnGrilla();
            MostrarCantidadRegistors();
        }

        private void BorrarTSB_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DatosDataGridView.SelectedRows[0];
                Libro libro = (Libro)r.Tag;
                DialogResult dr =
                    MessageBox.Show($"¿Desea dar de baja a ''{libro.NombreDelLibro}''?",
                    "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                RepositorioDeLibros.GetInstancia().Borrar(libro);
                DatosDataGridView.Rows.Remove(r);
                MessageBox.Show("Registro borrado", "Confirmar baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarCantidadRegistors();

            }
            

        }

        private void EditarTSB_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DatosDataGridView.SelectedRows[0];
                Libro libro = (Libro)r.Tag;
                Libro libroCopia = (Libro)libro.Clone();
                FrmLibroAE frm = new FrmLibroAE();
                frm.Text = "Editar Libro";
                frm.SetLibro(libroCopia);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                libroCopia = frm.GetLibro(); 
                if (RepositorioDeLibros.GetInstancia().Existe(libroCopia))
                {
                    MessageBox.Show("Libro existente!!", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                RepositorioDeLibros.GetInstancia().Editar(libro,libroCopia);
                SetearFila(r, libroCopia);
                MessageBox.Show("Registro editado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void policialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().GetListaFiltradaPorTema(Tema.Policial);
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
            


        }

        private void ActualizarCantidadRegistros()
        {
            cantidadRegistros = lista.Count;
            CantidadRegistrosLabel.Text = cantidadRegistros.ToString();
        }

        private void novelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().GetListaFiltradaPorTema(Tema.Novela);
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void cienciaFicciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().GetListaFiltradaPorTema(Tema.Ciencia_Ficcion);
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void romanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().GetListaFiltradaPorTema(Tema.Romance);
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void escolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().GetListaFiltradaPorTema(Tema.Escolar);
            ActualizarCantidadRegistros();
        }

        private void dramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().GetListaFiltradaPorTema(Tema.Drama);
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void alianzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista=RepositorioDeLibros.GetInstancia().GetListaFiltradaPorEditorial(Editorial.Alianza);
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void estradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista=RepositorioDeLibros.GetInstancia().GetListaFiltradaPorEditorial(Editorial.Estrada);
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void harperCollinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().GetListaFiltradaPorEditorial(Editorial.HarperCollins);
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void houghtonMifflinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().GetListaFiltradaPorEditorial(Editorial.Houghton_Mifflin_Harcout);
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void penguinGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().GetListaFiltradaPorEditorial(Editorial.Penguin_Group);
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void randomHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().GetListaFiltradaPorEditorial(Editorial.Random_House);
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void actualizarTSB_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
            MostrarCantidadRegistors();
        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().OrdenarAscPorPaginas();
            MostrarDatosEnGrilla();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeLibros.GetInstancia().OrdenarDescPorPaginas();
            MostrarDatosEnGrilla();
        }
    }
}
