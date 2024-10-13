using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Ejemplo_Clase
{
    public class Calculadora
    {
        // Definir campo para almacenar resultado
        private double memoria = 0;

        // Definir propiedad para acceder y guardar en la memoria
        public double MemoriaCalculadora
        {
            get; set;
        }

        // Método que suma dos números
        public double Sumar(double num1, double num2)
        { 
            double resultado = num1 + num2;
            memoria = resultado;
            return resultado; 
        }

        // Método que resta dos números
        public double Restar(double rest1, double rest2)
        {
            double resultado = rest1 - rest2;
            memoria = resultado;
            return resultado;
        }

        // Método que divide dos números
        public double Dividir(double div1, double div2)
        {
            if (div2 == 0)
            {
                MostrarMensajes("No se puede dividir por cero");
                return 0;
            }
            double resultado = div1 / div2;
            memoria = resultado;
            return div1 / div2;
        }

        // Método que multiplica dos números
        public double Multi(double mul1, double mul2)
        {
            double resultado = mul1 * mul2;
            memoria = resultado;
            return resultado;
        }
        
        // Método que muestra un mensaje por pantalla
        public void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        // Método que guarda en memoria o bien un valor pasado como parametro
        public void GuardarEnMemoria(double valor = 0)
        {
            memoria = valor;
        }

        // Método para obtener un valor numérico de la consola
        // y devolverlo como doble para evitar que el programa 
        // se bloquee si no es numérico
        public double ObtenerNumeroConsola()
        {
            double numero = 0;
            bool esNumero = false;
            while (!esNumero)
            {
                string? valor = Console.ReadLine();
                esNumero = double.TryParse(valor, out numero);
                if (!esNumero)
                {
                    MostrarMensajes("El valor introducido no es un número. Inténtalo de nuevo");
                }
            }
            return numero;
        }
    }
}
