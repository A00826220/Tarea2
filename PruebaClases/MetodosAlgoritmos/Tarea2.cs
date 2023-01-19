using PruebaClases.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClases.MetodosAlgoritmos
{
    public class Tarea2
    {
        public List<Demanda> listaDemandas = new List<Demanda>();
        public Tarea2()
        {
        }
        // Objetivo: Método realizará el promedio de una lista de demandas
        public double CalcularMedia(List<Demanda> listaDem)
        {
            // Paso 1: Declarar variables y setearlas
            double media = 0, suma = 0;
            // Paso 2: Calcular la variable suma (ACUMULADO)
            foreach (Demanda demanda2 in listaDem)
            {
                suma = suma + demanda2.suma;
            }
            // Paso 3: Dividir entre total de datos (PROMEDIO)
            // Paso 3.1: Condicionar a tener datos en la listaDem
            if (listaDem.Count() > 0)
            {
                media = suma / listaDem.Count();
            }
            return media;
        }
        public double CalcularVarianza(List<Demanda> listaDem, double media)
        {
            // Paso 1: Declarar variables y setearlas
            double varianza = 0, suma = 0;
            // Paso 2: Calcular la variable suma (ACUMULADO)
            foreach (Demanda demanda2 in listaDem)
            {
                varianza = suma + (demanda2.suma - media) * (demanda2.suma - media);
            }
            // Paso 3: Dividir entre total de datos (PROMEDIO)
            // Paso 3.1: Condicionar a tener datos en la listaDem
            if (listaDem.Count() > 0)
            {
                varianza = suma / listaDem.Count();
            }
            return varianza;
        }
        public double CalcularDesviacionEstandar(List<Demanda> listaDem)
        {
            // Paso 1: Declarar variables y setearlas
            double varianza = 0, desviacionEstandar = 0;
            // Paso 2: Calcular la variable suma (ACUMULADO)
            foreach (Demanda demanda2 in listaDem)
            {
                desviacionEstandar = Math.Sqrt(varianza);
            }
            // Paso 3: Dividir entre total de datos (PROMEDIO)
            // Paso 3.1: Condicionar a tener datos en la listaDem
            if (listaDem.Count() > 0)
            {

            }
             return desviacionEstandar;
        }
        // Llena datos de manera aleatorio Uniforme
        public void LlenarDatosAleatorios(int numeroDatos,
             int limiteInferior, int limiteSuperior)
        {
            // Paso 1: Declarar la variable aleatorio (Entrada un tiempo)
            Random aleatorio = new Random(Environment.TickCount);
            // Paso 2: Realizar un ciclo, para generar una cantidad "numeroDatos" de valores aleatorios
            for (int i = 0; i < numeroDatos; i++)
            {
                // (Generar valores aleatorios entre cero y uno)
                double value = aleatorio.NextDouble();
                // Paso 2.1:  Generar valor aleatorio (VARIABLE) entre limite inferior y limite superior (Entero)
                double value2 = aleatorio.Next(limiteInferior, limiteSuperior);
                double value3 = aleatorio.Next(limiteInferior, limiteSuperior);

                // Paso 2.2:  Declarar e inicializar variable "demanda"
                Demanda demanda = new Demanda();
                // Paso 2.3: Settear el atributo "idDemanda" con la variable "i" (castear)
                demanda.IdDemanda = i.ToString();
                // Paso 2.4: Asignar el "value2" a cantidad requerida 
                demanda.CantidadRequerida = value2;
                demanda.suma = value2 + value3;

                // Paso 2.5: Agregar el objeto demanda a la listaDemanda 
                listaDemandas.Add(demanda);
            }
        }

        public double AlgoritmoGenerarAleatoriosMedia(int numeroDatos,
            int limiteInferior, int limiteSuperior)
        {

            double media = 0;

            LlenarDatosAleatorios(numeroDatos, limiteInferior, limiteSuperior);

            media = CalcularMedia(listaDemandas);

            return media;
        }
        public double AlgoritmoGenerarAleatoriosVarianza(int numeroDatos,
           int limiteInferior, int limiteSuperior)
        {
            double Varianza = 0;
            

            LlenarDatosAleatorios(numeroDatos, limiteInferior, limiteSuperior);

            Varianza = CalcularVarianza(listaDemandas);

            return Varianza;
        }

        public double CalcularVarianza(List<Demanda> listaDemandas)
        {
            throw new NotImplementedException();
        }

        public double AlgoritmoGenerarDesviacionEstandar(int numeroDatos,
          int limiteInferior, int limiteSuperior)
        {

            double desviacionEstandar = 0;

            LlenarDatosAleatorios(numeroDatos, limiteInferior, limiteSuperior);

            desviacionEstandar = CalcularDesviacionEstandar(listaDemandas);

            return desviacionEstandar;
        }
    }
}