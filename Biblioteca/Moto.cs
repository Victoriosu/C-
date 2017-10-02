using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : Vehiculo
    {
        ModeloMoto _modeloMoto;
        MarcaMoto _marcaMoto;

        public Moto(ModeloMoto _modeloMoto, MarcaMoto _marcaMoto, string id, string año, int precio, Color color, TipoVehiculo tipo)
            : base(id, año, precio, color, tipo)
        {
            this._modeloMoto = _modeloMoto;
            this._marcaMoto = _marcaMoto;
        }

        public ModeloMoto ModeloMoto
        {
            get
            {
                return _modeloMoto;
            }

            set
            {
                _modeloMoto = value;
            }
        }

        public MarcaMoto MarcaMoto
        {
            get
            {
                return _marcaMoto;
            }

            set
            {
                _marcaMoto = value;
            }
        }
    }
}
