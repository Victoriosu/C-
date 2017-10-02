using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        String _email, _id, _rut, _nombre, _apellido, _numeroTelefono;
        char _sexo;

        public Usuario(string _email, string _id, string _rut, string _nombre, string _apellido, string _numeroTelefono, char _sexo)
        {
            this._email = _email;
            this._id = _id;
            this._rut = _rut;
            this._nombre = _nombre;
            this._apellido = _apellido;
            this._numeroTelefono = _numeroTelefono;
            this._sexo = _sexo;
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }

            set
            {
                _apellido = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
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

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string NumeroTelefono
        {
            get
            {
                return _numeroTelefono;
            }

            set
            {
                _numeroTelefono = value;
            }
        }

        public string Rut
        {
            get
            {
                return _rut;
            }

            set
            {
                _rut = value;
            }
        }

        public char Sexo
        {
            get
            {
                return _sexo;
            }

            set
            {
                _sexo = value;
            }
        }
    }
}
