using PiramideRectangularFinalProg.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramideRectangularFinalProg.Datos
{
    public class RepositorioDePiramides
    {

        private List<PiramideRectangular> _listaPiramides;

        private string nombreArchivo = "Piramides.txt";
        private string rutaProyecto = Environment.CurrentDirectory;
        private string? rutaCompletaArchivo;

        public RepositorioDePiramides()
        {
            _listaPiramides = new List<PiramideRectangular>();
            rutaCompletaArchivo = Path.Combine(rutaProyecto, nombreArchivo);
            _listaPiramides = leerDatos();
        }

        public bool Agregar(PiramideRectangular piramide)
        {
            if (piramide == null)
                return false;

            if (!Existe(piramide))
            {
                _listaPiramides.Add(piramide);
                return true;
            }

            return false;
        }


        public List<PiramideRectangular>? GetPiramides()
        {
            return _listaPiramides;
        }

        public int getCantidadPiramides()
        {
            return _listaPiramides.Count;
        }

        public int getCantidadPiramides(PiramideColor color) 
        {
            return _listaPiramides.Count(p => p.Color == color);
        }

        public bool Existe(PiramideRectangular piramide)
        {
            if (piramide == null)
                return false;

            return _listaPiramides.Any(p =>
                p.LadoBase == piramide.LadoBase &&
                p.Altura == piramide.Altura &&
                p.CantidadLados == piramide.CantidadLados &&
                p.Material == piramide.Material &&
                p.Color == piramide.Color);
        }
        public bool Existe(PiramideRectangular piramide, PiramideRectangular excluir)
        {
            if (piramide == null)
                return false;

            return _listaPiramides.Any(p =>
                p != excluir && // clave: evitar comparar contra la misma
                p.LadoBase == piramide.LadoBase &&
                p.Altura == piramide.Altura &&
                p.CantidadLados == piramide.CantidadLados &&
                p.Material == piramide.Material &&
                p.Color == piramide.Color);
        }
        public void guardarDatos()
        {
            using (var escritor = new StreamWriter(rutaCompletaArchivo!))
            {
                foreach (var piramide in _listaPiramides)
                {
                    string linea = construirLinea(piramide);
                    escritor.WriteLine(linea);
                }
            }
        }
        private List<PiramideRectangular> leerDatos()
        {
            var lista = new List<PiramideRectangular>();
            if (!File.Exists(rutaCompletaArchivo))
            {
                return lista;
            }
            using (var lector = new StreamReader(rutaCompletaArchivo!))
            {
                while (!lector.EndOfStream)
                {
                    string? lineaLeida = lector.ReadLine();

                    if (string.IsNullOrWhiteSpace(lineaLeida)) continue;
                    PiramideRectangular piramide = construirPiramide(lineaLeida);
                    lista.Add(piramide);
                }
            }
            return lista;
        }

        private PiramideRectangular construirPiramide(string? lineaLeida)
        {
            var campos = lineaLeida!.Split("|");
            int ladoBase = int.Parse(campos[0]);
            int altura = int.Parse(campos[1]);
            int cantidadLados = int.Parse(campos[2]);
            PiramideMaterial material = (PiramideMaterial)int.Parse(campos[3]);
            PiramideColor color = (PiramideColor)int.Parse(campos[4]);

            return new PiramideRectangular(ladoBase, cantidadLados, material, color)
            {
                Altura = altura
            };
        }

        private string construirLinea(PiramideRectangular piramide)
        {
            return $"{piramide.LadoBase}|{piramide.CantidadLados}|{(int)piramide.Material}" +
                $"|{(int)piramide.Color}|{piramide.Altura}|{piramide.CalcularVolumen():F2}";
        }

        public void Borrar(PiramideRectangular piramide)
        {
            _listaPiramides.Remove(piramide);
        }
        public List<PiramideRectangular> getListaOrdenada(Orden orden)
        {
            if (orden == Orden.Asc)
            {
                return _listaPiramides.OrderBy(p => p.CalcularVolumen()).ToList();
            }
            return _listaPiramides.OrderByDescending(p => p.CalcularVolumen()).ToList();
        }

        public List<PiramideRectangular>? Filtrar(PiramideColor color)
        {
            return _listaPiramides.Where(p => p.Color == color).ToList();
        }

        public void Editar(PiramideRectangular original, PiramideRectangular editada)
        {
            int index = _listaPiramides.IndexOf(original);
            if (index != -1)
            {
                _listaPiramides[index] = editada;
            }
        }
    }
}
