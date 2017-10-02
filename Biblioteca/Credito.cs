using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Credito : Billing
    {
        string _nroTarjeta, _cvv, _f_venc;//Solo mes y año

        public Credito(string _nroTarjeta, string _cvv, string _f_venc, string id, Cliente cliente)
            : base(id, cliente)
        {
            this._nroTarjeta = _nroTarjeta;
            this._cvv = _cvv;
            this._f_venc = _f_venc;
        }

        public string Cvv
        {
            get
            {
                return _cvv;
            }

            set
            {
                _cvv = value;
            }
        }

        public string F_venc
        {
            get
            {
                return _f_venc;
            }

            set
            {
                _f_venc = value;
            }
        }

        public string NroTarjeta
        {
            get
            {
                return _nroTarjeta;
            }

            set
            {
                _nroTarjeta = value;
            }
        }
    }
}
