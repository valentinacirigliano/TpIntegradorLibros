﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpIntegradorLibros.Entidades;

namespace TpIntegradorLibros.Datos
{
    class ManejadorDeArchivo
    {
        private readonly string _archivo = Environment.CurrentDirectory + @"\Libros.txt";
        private readonly string _archivobak = Environment.CurrentDirectory + @"\Libros.bak";

        public void EditarRegistroEnArchivo(Libro libromodificado)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivobak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                var libroEnArchivo = ConstruirLibro(linea);
                if (libroEnArchivo.Equals(libromodificado))
                {
                    linea = ConstruirLinea(libromodificado);
                }
                escritor.WriteLine(linea);
            }

            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivobak, _archivo);
        }

        public List<Libro> LeerDatosDelArchivo()
        {
            var lista = new List<Libro>();
            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Libro libro = ConstruirLibro(linea);
                    lista.Add(libro);
                }
               
            } return lista;
        }


        private Libro ConstruirLibro(string linea)
        {
            var campos = linea.Split('|');
            return new Libro()
            {
                NombreDelLibro = campos[0],
                Editorial = (Editorial)int.Parse(campos[1]),
                Tema = (Tema)int.Parse(campos[2]),
                Paginas = int.Parse(campos[3]),
                ISBN = int.Parse(campos[4]),
                Autor = campos[5]
            };
        }

        public void BorrarRegistroEnArchivo(Libro libro)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivobak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Libro libroEnArchivo = ConstruirLibro(linea);
                if (!libroEnArchivo.Equals(libro))
                {
                    escritor.WriteLine(linea);
                }
            }
            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivobak, _archivo);
        }

        public void GuardarEnArchivo(Libro libro)
        {
            StreamWriter escritor = new StreamWriter(_archivo, true);
            string linea = ConstruirLinea(libro);
            escritor.WriteLine(linea);
            escritor.Close();
        }


        private string ConstruirLinea(Libro libro)
        {
            return $" {libro.NombreDelLibro} | {libro.Editorial.GetHashCode()} | " +
                    $" {libro.Tema.GetHashCode()} | {libro.Paginas} | " +
                    $" {libro.ISBN} | {libro.Autor} ";
        }

    }
}
