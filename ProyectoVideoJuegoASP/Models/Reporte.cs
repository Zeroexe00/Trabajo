//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoVideoJuegoASP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reporte
    {
        public int id { get; set; }
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
}
