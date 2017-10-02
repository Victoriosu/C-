using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca
{

    public enum TipoPago
    {
        Debito,
        Credito,
        Paypal
    }
    public enum MarcaAuto
    {
        Audi,
        Nissan
    }

    public enum MarcaMoto
    {
        Kawasaki,
        Piaggio,
        Kymco
    }

    public enum Anio
    {
        _1990,
        _1991,
        _1992,
        _1993,
        _1994,
        _1995,
        _1996,
        _1997,
        _1998,
        _1999,
        _2000,
        _2001,
        _2002,
        _2003,
        _2004,
        _2005,
        _2006,
        _2007
    }

    public enum  ModeloAuto
    {
        Audi,
        Nissan
    }

    public enum ModeloMoto
    {
        Kawasaki,
        Piaggio
    }

    public enum TipoVehiculo
    {
            Auto,
            Moto
    }
    public enum ModeloAudi
    {
        A1,
        A2
    }
    public enum ModeloNissan
    {
        Tida,
        BlueBird
    }

    public enum ModeloPiaggio
    {
        Medley,
        New_Liberty
    }

    public enum ModeloKawasaki
    {
        Z650,
        Vulcan
    }

    public enum Color
    {
        Azul,
        Rojo,
        Plateado,
        Verde,
        Tuquesa,
        Blanco,
        Negro
    }


}
