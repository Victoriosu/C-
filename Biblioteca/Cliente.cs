using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        string _id, _rut, _nombre, _apellido, _numeroTelefono, _email, _direccion;
        DateTime _fNacimiento;

        public Cliente(string _id, string _rut, string _nombre, string _apellido, string _numeroTelefono, string _email, string _direccion, DateTime _fNacimiento)
        {
            this._id = _id;
            this._rut = _rut;
            this._nombre = _nombre;
            this._apellido = _apellido;
            this._numeroTelefono = _numeroTelefono;
            this._email = _email;
            this._direccion = _direccion;
            this._fNacimiento = _fNacimiento;
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

        public string Direccion
        {
            get
            {
                return _direccion;
            }

            set
            {
                _direccion = value;
            }
        }

        public DateTime FNacimiento
        {
            get
            {
                return _fNacimiento;
            }

            set
            {
                _fNacimiento = value;
            }
        }
    }
}
