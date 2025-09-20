using System;
using System.Collections.Generic;

namespace GarajeMVC.Models
{
    public class Garage
    {
        public int numeroGarage { get; set; }
        public string descripcion { get; set; }
        public int capacidadEspacios { get; set; }
        public int espaciosOcupados { get; set; }
        public List<Auto> autos { get; set; }

        public Garage(int numeroGarage, string descripcion, int capacidadEspacios)
        {
            this.numeroGarage = numeroGarage;
            this.descripcion = descripcion;
            this.capacidadEspacios = capacidadEspacios;
            this.espaciosOcupados = 0;
            this.autos = new List<Auto>();
        }

        public void ingresarAuto(Auto auto)
        {
            if (espaciosOcupados < capacidadEspacios)
            {
                autos.Add(auto);
                espaciosOcupados++;
            }
            else
            {
                Console.WriteLine("Garage lleno, no se puede agregar el auto.");
            }
        }

        public List<Auto> GetAutos()
        {
            return autos;
        }

        public string getDescripcion()
        {
            return descripcion;
        }
    }
}