using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Debito : Billing
    {
        //serieAleatorio emula a las coordenadas secretas.
        string nroTarjeta, _serieAleatoria;

        public Debito(string nroTarjeta, string _serieAleatoria, string id, Cliente cliente)
            : base(id, cliente)
        {
            this.nroTarjeta = nroTarjeta;
            this._serieAleatoria = _serieAleatoria;
        }

        public string NroTarjeta
        {
            get
            {
                return nroTarjeta;
            }

            set
            {
                nroTarjeta = value;
            }
        }

        public string SerieAleatoria
        {
            get
            {
                return _serieAleatoria;
            }

            set
            {
                _serieAleatoria = value;
            }
        }
    }
}
