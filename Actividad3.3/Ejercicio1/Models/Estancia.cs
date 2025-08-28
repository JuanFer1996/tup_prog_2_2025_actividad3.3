using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Estancia
    {
        public string Nombre { get; set; }
        public Casco casco { get; set; }
        ArrayList puestos =new ArrayList();

        public Estancia(string nombre, string IDcampo, double superficie,)
        {
            this.Nombre = nombre;
            this.casco=new Casco();
            this.casco.administrador = "sin asiganar";
            puestos.Add(new Puesto());
            ((Puesto)puestos[0]).Responsable = "sin asignar";
            
            
            //Puesto puesto = new Puesto();
            //puestos.Add(puesto);
            //puesto.Responsable = "sin asignar";
        }
    }
}
