using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Heroe
    {
        string nombre;
        string poder;
        int nivelFuerza;
        bool esAyudante;

        
        public Heroe(string nombre, string poder, int nivelFuerza)
        {
            this.SetNombre(nombre);
            this.SetPoder(poder);
            this.SetNivelFuerza(nivelFuerza);
            this.SetEsAyudante(this.GetNivelFuerza() < 50);
        }

        #region get/set
        public string GetNombre()
        {
            return this.nombre;
        }

        public bool SetNombre(string nombreQueLlega)
        {
            if (string.IsNullOrEmpty(nombreQueLlega))
                return false;

            this.nombre = nombreQueLlega;
            return true;
        }

        public string GetPoder()
        {
            return this.poder;
        }

        public void SetPoder(string poder)
        {
            if (!string.IsNullOrEmpty(poder))
                this.poder = poder;
        }

        public int GetNivelFuerza()
        {
            
            return this.nivelFuerza;
        }

        public void SetNivelFuerza(int nivelFuerza)
        {
            
            if ( nivelFuerza >= 0)
                this.nivelFuerza =  nivelFuerza;
        }

        public bool GetEsAyudante()
        {
            return this.esAyudante;
        }

        public void SetEsAyudante(bool esAyudante)
        {
            this.esAyudante = esAyudante;
        }

        #endregion
        private string HeroeToString2()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.GetNombre()}");
            sb.AppendLine($"Poder: {this.GetPoder()}");
            sb.AppendLine($"Nivel de Fuerza: {this.GetNivelFuerza()}");

            if (this.GetEsAyudante())
                sb.AppendLine($"Es ayudante?: SI");
            else
                sb.AppendLine($"Es ayudante?: NO");

            return sb.ToString();
            // return $"Nombre: {nombre}\nPoder: {poder}\nNivel fuerza: {nivelFuerza}\nEs ayudante: {esAyudante}";
        }
        public string HeroeToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.GetNombre()}");
            sb.AppendLine($"Poder: {this.GetPoder()}");
            sb.AppendLine($"Nivel de Fuerza: {this.GetNivelFuerza()}");

            if (this.GetEsAyudante())
                sb.AppendLine($"Es ayudante?: SI");
            else
                sb.AppendLine($"Es ayudante?: NO");

            return sb.ToString();
            // return $"Nombre: {nombre}\nPoder: {poder}\nNivel fuerza: {nivelFuerza}\nEs ayudante: {esAyudante}";
        }

    }
}
