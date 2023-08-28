using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismaRectangularRecto
{
    public class Prisma
    {
        private int _altura;
        private int _largo;
        private int _ancho;

        public int GetAltura() => _altura;
        public int GetAncho() => _ancho;
        public int GetLargo() => _largo;

        public Prisma(int altura, int largo, int ancho)
        {
            if (EsValido(altura,largo,ancho))
            {
                _altura = altura;
                _largo = largo;
                _ancho = ancho;
            } 
            
        }

        private bool EsValido(int altura, int largo, int ancho)
        {
            if (altura<=0||largo<=0||ancho<=0)
            {
                return false;
            }
            return true;
        }

        public Prisma()
        {
            _altura = 1;
            _largo = 1;
            _ancho = 1;
        }

        private int AreaBase()
        {
            return (GetAncho() * GetLargo());
        }
        private int AreaAltura()
        {
            return (GetAltura() * GetAncho());
        }
        private int AreaAncho()
        {
            return (GetAltura() * GetLargo());
        }

        public int GetArea()
        {
            return (2 * (AreaAltura() + AreaAncho() + AreaBase()));
        }
        public int GetVolumen()
        {
            return (GetAltura()*GetAncho()*GetLargo());
        }
        public int GetDiagonal()
        {
            return (int)Math.Sqrt(Math.Pow(GetLargo(),2)+Math.Pow(GetAncho(),2)+Math.Pow(GetAltura(),2));
        }
        
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Prisma Rectangular Recto");
            sb.AppendLine($"Area.......:{GetArea()}");
            sb.AppendLine($"Volumen....:{GetVolumen()}");
            sb.AppendLine($"Diagonal...:{GetDiagonal()}");

            return sb.ToString();
        }

    }
    
}
