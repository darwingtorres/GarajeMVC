using System;

namespace GarajeMVC.Models
{
    public class Auto
    {
        public int numeroAuto { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }

        public Auto(int numeroAuto, string marca, string placa)
        {
            this.numeroAuto = numeroAuto;
            this.Marca = marca;
            this.Placa = placa;
        }
    }
}