using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vehiculo
    {
        string _id, _año;
        int _precio;
        Color _color;
        TipoVehiculo _tipo;

        public Vehiculo(string _id, string _año, int _precio, Color _color, TipoVehiculo _tipo)
        {
            this._id = _id;
            this._año = _año;
            this._precio = _precio;
            this._color = _color;
            this._tipo = _tipo;
        }

        public Vehiculo()
        {

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

        public string Año
        {
            get
            {
                return _año;
            }

            set
            {
                _año = value;
            }
        }

        public int Precio
        {
            get
            {
                return _precio;
            }

            set
            {
                _precio = value;
            }
        }

        public Color Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public TipoVehiculo Tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                _tipo = value;
            }
        }
    }
}
