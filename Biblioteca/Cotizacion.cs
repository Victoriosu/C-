using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cotizacion
    {
        string _id;
        Vehiculo _vehiculo;
        Cliente _cliente;

        public Cotizacion(string _id, Vehiculo _vehiculo, Cliente _cliente)
        {
            this._id = _id;
            this._vehiculo = _vehiculo;
            this._cliente = _cliente;
        }

        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public Vehiculo Vehiculo
        {
            get
            {
                return _vehiculo;
            }

            set
            {
                _vehiculo = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return _cliente;
            }

            set
            {
                _cliente = value;
            }
        }
    }
}
