using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Billing
    {
        string _id;
        Cliente _cliente;
        TipoPago _tipoPago;

        public Billing(string _id, Cliente _cliente, TipoPago _tipoPago)
        {
            this._id = _id;
            this._cliente = _cliente;
            this._tipoPago = _tipoPago;
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

        public TipoPago TipoPago
        {
            get
            {
                return _tipoPago;
            }

            set
            {
                _tipoPago = value;
            }
        }
    }
}
