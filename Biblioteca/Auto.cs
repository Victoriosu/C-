using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Auto : Vehiculo
    {
        MarcaAuto _marcaAuto;
        ModeloAuto _modeloAuto;

        public Auto( MarcaAuto _marcaAuto, ModeloAuto _modeloAuto, string id, string año, int precio, Color color, TipoVehiculo tipo)
            : base(id,año, precio, color, tipo)//Precio
        {
            this._marcaAuto = _marcaAuto;
            this._modeloAuto = _modeloAuto;
        }

        public MarcaAuto MarcaAuto
        {
            get
            {
                return _marcaAuto;
            }

            set
            {
                _marcaAuto = value;
            }
        }

        public ModeloAuto ModeloAuto
        {
            get
            {
                return _modeloAuto;
            }

            set
            {
                _modeloAuto = value;
            }
        }
    }
}
