using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TpIntegradorLibros.Entidades;

namespace TpIntegradorLibros.Datos
{
    public class RepositorioDeLibros
    {
        private List<Libro> listaLibros;
        private ManejadorDeArchivo manejador;

        public static RepositorioDeLibros _instancia = null;

        //De esta manera solo tengo un repositorio
        public static RepositorioDeLibros GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new RepositorioDeLibros();
            }

            return _instancia;
        }
        private RepositorioDeLibros()
        {
            listaLibros = new List<Libro>();
            manejador = new ManejadorDeArchivo();
            listaLibros = manejador.LeerDatosDelArchivo();
        }

        public List<Libro> GetLista()
        {
            return listaLibros;
        }

        public void Agregar(Libro libro)
        {
            manejador.GuardarEnArchivo(libro);
            listaLibros.Add(libro);
        }

        public void Editar(Libro libroOriginal, Libro libroModificado)
        {
            manejador.EditarRegistroEnArchivo(libroOriginal,libroModificado);
            int index = listaLibros.IndexOf(libroOriginal);
            listaLibros.RemoveAt(index);
            listaLibros.Insert(index, libroModificado);


        }

        public void Borrar(Libro l)
        {
            manejador.BorrarRegistroEnArchivo(l);
            listaLibros.Remove(l);
        }

        public bool Existe(Libro libro)
        {
            return listaLibros.Contains(libro);
        }

        public int GetCantidad()
        {
            return listaLibros.Count;
        }

        public List<Libro> GetListaFiltradaPorTema(Tema tema)
        {
            return listaLibros.Where(l=>l.Tema==tema).ToList();
        }

        public List<Libro> GetListaFiltradaPorEditorial(Editorial editorial)
        {
            return listaLibros.Where(l=>l.Editorial==editorial).ToList();
        }

        public List<Libro> OrdenarAscPorPaginas()
        {
            return listaLibros.OrderBy(l=>l.Paginas).ToList();
        }

        public List<Libro> OrdenarDescPorPaginas()
        {
            return listaLibros.OrderByDescending(l=>l.Paginas).ToList();
        }
    }
}
