﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BiblioWeb.Models
{
    public class Libro : ModeloBase
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Falta agregar el código")]
        public string CodigoInterno { get; set; }
        [Required(ErrorMessage = "Falta agregar Título")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Falta agregar Autor")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Falta agregar Editorial")]
        public string Editorial { get; set; }
        public bool Disponible { get; set; }
        public string Disponibilidad
        {
            get { return Disponible ? "Disponible" : "No Disponible"; }
        }
        public byte[] Imagen { get; set; }
        public int TematicaId { get; set; }
        public Tematica Tematica { get; set; }
        public ICollection<Prestamo> Prestamos { get; set; }
    }
}
