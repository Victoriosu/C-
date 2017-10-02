using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Paypal : Billing
    {
        string _username, _correo;
        Boolean _envio;

        public Paypal(string _username, string _correo, bool _envio, string id, Cliente cliente)
            : base(id, cliente)
        {
            this._username = _username;
            this._correo = _correo;
            this._envio = _envio;
        }

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public string Correo
        {
            get
            {
                return _correo;
            }

            set
            {
                _correo = value;
            }
        }

        public bool Envio
        {
            get
            {
                return _envio;
            }

            set
            {
                _envio = value;
            }
        }
    }
}
