using System;

namespace Primer_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada = "";
            int Actividad = 0;
            double Kg = 0.0;
            int Opcion = 0;
            
            do{ 
                Console.WriteLine("\nBienvenidos, el siguiente programa informara cuanta porcion de alimentos debe comer su perro.\n");
                Console.WriteLine("Ingrese el peso de su perro en Kg:");
                Entrada = Console.ReadLine();
                Kg = Convert.ToDouble(Entrada);
                Console.WriteLine("\nIngrese el nivel de actividad de su perro:");
                Console.WriteLine("[1] - Actividad Alta");
                Console.WriteLine("[2] - Actividad Normal");
                Console.WriteLine("[3] - Actividad Baja");
                Entrada = Console.ReadLine();
                Actividad = Convert.ToInt32(Entrada);
                
                if (Kg <= 5 && Kg >= 2)
                {
                    switch (Actividad) {
                        case 1:
                            Console.WriteLine("\nSu perro debe comer entre 60 y 115 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("\nSu perro debe comer entre 55 y 100 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("\nSu perro debe comer entre 45 y 85 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nSu seleccion no esta disponible, intente otra vez");
                            break;
                    }
                    
                } else if (Kg <= 10 && Kg > 5) {
                    switch (Actividad) {
                        case 1:
                            Console.WriteLine("\nSu perro debe comer entre 115 y 190 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("\nSu perro debe comer entre 100 y 170 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("\nSu perro debe comer entre 85 y 145 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nSu seleccion no esta disponible, intente otra vez");
                            break;
                    }

                } else if (Kg <= 15 && Kg > 10) {
                    switch (Actividad) {
                        case 1:
                            Console.WriteLine("\nSu perro debe comer entre 190 y 255 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("\nSu perro debe comer entre 170 y 225 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("\nSu perro debe comer entre 145 y 195 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nSu seleccion no esta disponible, intente otra vez");
                            break;
                    }

                } else if (Kg <= 25 && Kg > 15) {
                    switch (Actividad) {
                        case 1:
                            Console.WriteLine("\nSu perro debe comer entre 255 y 380 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("\nSu perro debe comer entre 225 y 330 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("\nSu perro debe comer entre 195 y 285 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nSu seleccion no esta disponible, intente otra vez");
                            break;
                    }

                } else if (Kg <= 40 && Kg > 25) {
                    switch (Actividad) {
                        case 1:
                            Console.WriteLine("\nSu perro debe comer entre 380 y 535 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("\nSu perro debe comer entre 330 y 475 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("\nSu perro debe comer entre 285 y 410 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nSu seleccion no esta disponible, intente otra vez");
                            break;
                    }

                } else if (Kg <= 55 && Kg > 40) {
                    switch (Actividad) {
                        case 1:
                            Console.WriteLine("\nSu perro debe comer entre 535 y 680 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("\nSu perro debe comer entre 475 y 600 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("\nSu perro debe comer entre 410 y 520 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nSu seleccion no esta disponible, intente otra vez");
                            break;
                    }

                } else if (Kg <= 70 && Kg > 55) {
                    switch (Actividad) {
                        case 1:
                            Console.WriteLine("\nSu perro debe comer entre 680 y 820 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("\nSu perro debe comer entre 600 y 720 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("\nSu perro debe comer entre 520 y 620 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nSu seleccion no esta disponible, intente otra vez");
                            break;
                    }

                } else if (Kg <= 90 && Kg > 70) {
                    switch (Actividad) {
                        case 1:
                            Console.WriteLine("\nSu perro debe comer entre 820 y 985 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("\nSu perro debe comer entre 720 y 870 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("\nSu perro debe comer entre 620 y 750 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nSu seleccion no esta disponible, intente otra vez");
                            break;
                    }   
                }
                
                Console.WriteLine("\nSi desea volver a realizar el programa ingrese cualquier numero, de lo contrario escriba 0");
                Entrada = Console.ReadLine();
                Opcion = Convert.ToInt32(Entrada);
                
            }while(Opcion != 0);

            /*Irvin Sánchez
            C.I.: 28232012
            Carrera: Ing. en Información
            */
        }
    }
}
