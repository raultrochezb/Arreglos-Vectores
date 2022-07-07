using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//RaulTrochez
namespace appPrueba3
{
    class Program
    {
        private int[] vector;
        private int[,] matriz;
        private string tav;
        private string col;
        private string ren;
        private string valVec;
        private string valMat;
        private int i;
        private int j;
        int aux;
        string opcion;
        int op;

        public void Inicio()
        {
            do
            {
                Console.WriteLine("\n-------------------------------------");
                Console.WriteLine("Eliga una opcion: ");
                Console.WriteLine("1.-Vector");
                Console.WriteLine("2.-Matriz");
                Console.WriteLine("3.-Salir");
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
                op = Convert.ToInt32(opcion);
                try
                {
                    if (op == 1)
                    {
                        Vector();
                    }
                    else if (op == 2)
                    {
                        Matriz();
                    }
                }
                catch (Exception ex)
                {
                    Console.Write("Error ingrese una opcion valida " + ex);
                }
            } while (op != 3);

        }
        public void Vector()
        {
            Console.WriteLine("\nEliga una opcion: ");
            Console.WriteLine("1.-Ascendente");
            Console.WriteLine("2.-Descendente");
            Console.Write("Opcion: ");
            opcion = Console.ReadLine();
            op = Convert.ToInt32(opcion);
            try
            {
                if (op == 1)
                {
                    CargarVector();
                    LlenarVector();
                    OrdAscVec();
                }
                else if (op == 2)
                {
                    CargarVector();
                    LlenarVector();
                    OrdDscVec();
                }
            }
            catch (Exception ex)
            {
                Console.Write("\nError: " + ex);
            }
            DatosVec();

        }
        public void Matriz()
        {
            Console.WriteLine("\nEliga una opcion: ");
            Console.WriteLine("1.-Ascendente");
            Console.WriteLine("2.-Descendente");
            Console.Write("Opcion: ");
            opcion = Console.ReadLine();
            op = Convert.ToInt32(opcion);
            try
            {
                if (op == 1)
                {
                    CargarMatriz();
                    LlenarMatriz();
                    OrdAscMat();
                }
                else if (op == 2)
                {
                    CargarMatriz();
                    LlenarMatriz();
                    OrdDscMat();
                }
            }
            catch (Exception ex)
            {
                Console.Write("\nError: " + ex);
            }
            DatosMat();

        }
        public void CargarVector()
        {
            Console.Write("\nIngrese el tamaño del vector: ");
            tav = Console.ReadLine();
            vector = new int[Convert.ToInt32(tav)];
        }
        public void CargarMatriz()
        {
            Console.WriteLine("\nIngrese el tamaño de la Matriz");
            Console.Write("Ingrese el numero de columnas: ");
            col = Console.ReadLine();
            Console.Write("Ingrese el numero de renglones: ");
            ren = Console.ReadLine();
            matriz = new int[Convert.ToInt32(col), Convert.ToInt32(ren)];
        }
        public void LlenarVector()
        {
            for(i = 0; i<vector.Length; i++)
            {
                Console.Write("\nIngrese un valor para almacenar en el vector: ");
                valVec = Console.ReadLine();
                vector[i] = Convert.ToInt32(valVec);
            }
        }
        public void LlenarMatriz()
        {
            for (i = 0; i < Convert.ToInt32(col); i++)
            {
                for (j = 0; j < Convert.ToInt32(ren); j++)
                {
                Console.Write("\nIngrese un valor para almacenar la posicion["+(i+1)+"]["+(j+1)+"]= ");
                valMat = Console.ReadLine();
                matriz[i,j] = Convert.ToInt32(valMat);
            }
        }
        }
        public void OrdAscVec()
        {
            for (i = 1; i < vector.Length; i++)
                for (j = vector.Length - 1; j >= i; j--)
                {
                    if (vector[j - 1] > vector[j])
                    {
                        aux = vector[j - 1];
                        vector[j - 1] = vector[j];
                        vector[j] = aux;
                    }
                }
            ImprimirVec();
        }    
        public void OrdDscVec()
        {
            for (i = 1; i < vector.Length; i++)
                for (j = vector.Length - 1; j >= i; j--)
                {
                    if (vector[j - 1] < vector[j])
                    {
                        aux = vector[j - 1];
                        vector[j - 1] = vector[j];
                        vector[j] = aux;
                    }
                }
            ImprimirVec();
        }
        public void OrdAscMat()
        {
            for (i = 0; i < Convert.ToInt32(ren); i++)
                for (j = 0; j < Convert.ToInt32(col); j++)
                    for (int x = 0; x < Convert.ToInt32(ren); x++)
                        for (int y = 0; y < Convert.ToInt32(col); y++)
                            if (matriz[i,j] < matriz[x,y])
                            {
                                aux = matriz[i,j];
                                matriz[i,j] = matriz[x,y];
                                matriz[x,y] = aux;
                            }
            ImprimirMat();
        }
        public void OrdDscMat()
        {
            for (i = 0; i < Convert.ToInt32(ren); i++)
                for (j = 0; j < Convert.ToInt32(col); j++)
                    for (int x = 0; x < Convert.ToInt32(ren); x++)
                        for (int y = 0; y < Convert.ToInt32(col); y++)
                            if (matriz[i, j] > matriz[x, y])
                            {
                                aux = matriz[i, j];
                                matriz[i, j] = matriz[x, y];
                                matriz[x, y] = aux;
                            }
            ImprimirMat();
        }
        public void ImprimirVec()
        {
            Console.WriteLine("\nVector Ordenado:");
            foreach(int vec in vector)
            {
                Console.WriteLine(vec + " ");
            }
        }
        public void ImprimirMat()
        {
            Console.WriteLine("\nMatriz Ordenada:");
            for (i = 0; i<Convert.ToInt32(col); i++)
            {
                for (j = 0; j < Convert.ToInt32(ren); j++)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void DatosVec()
        {
            Console.WriteLine("\nVector");
            Console.WriteLine("El tamaño del vector es: " + tav);
        }
        public void DatosMat()
        {
            Console.WriteLine("\nMatriz");
            Console.WriteLine("El numero de columnas son: " + col);
            Console.WriteLine("El numero de renglones son: " + ren);
        }
        static void Main(string[] args)
        {
                Program arr = new Program();
                arr.Inicio();
                Console.ReadKey();
        }
    }
}