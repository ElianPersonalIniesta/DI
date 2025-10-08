using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCinco
{
    public class Informe
    {
        /// Atributos
        private string[] tareas = { "administrativo", "empresarial", "personal" };
        private int codigo;
        private string tarea;
        ///Constructor
        public Informe(int codigo, int indiceTarea)
        {
            this.codigo = codigo;
            ///La tarea se asigna con el índice del constructor
            this.tarea = this.tareas[indiceTarea];
        }
        ///Getters y Setters
        public int getCodigo() { return codigo; }
        public void setCodigo(int codigo) { this.codigo = codigo; }
        public string getTarea() { return tarea; }
        public void setTrea(String tarea) { this.tarea = tarea; }
        public string[] getTareas() { return tareas; }
        ///ToString overrideado
        public override string ToString()
        {
            return "El informe con codigo "+codigo+" tiene la tarea de "+tarea;
        }
    }
}
