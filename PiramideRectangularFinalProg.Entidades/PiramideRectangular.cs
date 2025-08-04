    using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramideRectangularFinalProg.Entidades
{
    public class PiramideRectangular
    {
        private int _ladoBase;
        private int _altura;
        private int _cantidadLados;

       public int LadoBase
       {
            get => _ladoBase;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado de la base debe ser mayor que cero.");
                _ladoBase = value;
            }
        }

        public int Altura
        {
            get => _altura;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La altura debe ser mayor que cero.");
                _altura = value;
            }
        }

        public int CantidadLados {
            get => _cantidadLados;
            set
            {
                if (value < 3 || value > 4)
                    throw new ArgumentException("La cantidad de lados debe ser 3 o 4.");
                _cantidadLados = value;
            }
        }
        public PiramideColor Color { get; set; }
        public PiramideMaterial Material { get; set; }


        public PiramideRectangular(int ladoBase, int cantidadLados, PiramideMaterial material, PiramideColor color)
        {
            LadoBase = ladoBase;
            CantidadLados = cantidadLados;
            Material = material;
            Color = color;
        }

        public double CalcularAreaBase()
        {

            if (CantidadLados == 3)
            {
                return (Math.Sqrt(3) / 4) * Math.Pow(LadoBase, 2);  //Math.sqrt divide la raiz, (3) significa dividido
                                                                    //raiz de 3 y / es dividido por 4
            }
            else if (CantidadLados == 4)
            {
                return Math.Pow(LadoBase, 2);
            }
            else
            {
                return 0;
            }

        }

        public double CalcularVolumen()
        {
            return (CalcularAreaBase() * Altura) / 3;
        }

        private double CalcularPerimetroBase()
        {
            return LadoBase * CantidadLados;
        }

        private double CalcularAlturaLateral()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(LadoBase / 2.0, 2));
        }

        public double CalcularAreaLateral()
        {
            return (CalcularPerimetroBase() * CalcularAlturaLateral()) / 2;
        }

        public double CalcularAreaTotal()
        {
            return CalcularAreaBase() + CalcularAreaLateral();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Volumen: {CalcularVolumen().ToString("N2")}");
            sb.AppendLine($"Perimetro Base: {CalcularPerimetroBase().ToString("N2")}");
            sb.AppendLine($"Altura Lateral: {CalcularAlturaLateral().ToString("N2")}");
            sb.AppendLine($"Area Lateral: {CalcularAreaLateral().ToString("N2")}");
            sb.AppendLine($"Area Total: {CalcularAreaTotal().ToString("N2")}");

            return sb.ToString();

        }

    }
}
