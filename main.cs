using System;
using System.Collections.Generic;

/*
No tienen las limitaciones de los arrays(a cambio de mayor consumo de recursos)Permiten:
Ordenar, Añadir, Eliminar, Buscar,Etc.
Colecciones mas frecuentes:
-
List<T>Parecidos a los arays pero con metodos adicionales para agregar, eliminar, ordenar, buscar, Etc
-
Queue<T> Las colas. un elemento entra y uno sale. Primero en entrar-primero en salir
-
Stack<T> parecidos a los queue pero con algunas diferencias. primero en entrar-ultimo en salir
-
LinkedList<T> comportamiento como queue o stack pero con acceso aleatorio
-
HashSet<T> Lista de valores sin ordenar
-
Dictionary<Tkey, Tvalue> almacena elementos con estructura de clave - valor
-
SortedList<Tkey, Tvalue> igual que los dictionary pero ordenados
*/

class MainClass {
  public static void Main (string[] args) {
		int n = 1;
    //instanciamos la lista con valores estaticos
    List<int> numeros_estaticos = new List<int>();
    numeros_estaticos.Add(5);
    numeros_estaticos.Add(6);
    numeros_estaticos.Add(7);
    for(int i = 0; i < 3;i++){
      Console.WriteLine(numeros_estaticos[i]);
    }
    Console.WriteLine("=========================");
    //instancia lista con array
    List<int> listaNumeros = new List<int>();
    int[] numeros_array = new int[]{20,30,50,80,100};
    //for para almacenar elementos
    for(int i = 0; i < 5; i++){
      listaNumeros.Add(numeros_array[i]);
    }
    //segundo for para recorre elementos
    for(int i = 0; i < 5; i++){
      Console.WriteLine(listaNumeros[i]);
    }

    Console.WriteLine("==========================");
    //instancia lista con valores dinamicos con cantidad especifica
    List<int> numeros_dinamicos = new List<int>();
    Console.WriteLine("Cuantos elementos quieres que tenga la lista:");
    int elem = int.Parse(Console.ReadLine());
    for(int i = 0; i < elem;i++){
			Console.WriteLine("Ingresa el {0} número:", n);
			n++;
      numeros_dinamicos.Add(int.Parse(Console.ReadLine()));
    }
		Console.WriteLine("Elementos introducidos:");
    for(int i = 0; i < elem; i++){
      Console.WriteLine(numeros_dinamicos[i]);
    }

    Console.WriteLine("==========================");
    //instancia lista con valores dinamicos con cantidad no especifica
    List<int> numeros_dinamicos_no = new List<int>();
    Console.WriteLine("Ingresa los elementos que desees en la lista:(0 para salir)");
    int e = 1;
    while(e !=0){
      e = int.Parse(Console.ReadLine());
      numeros_dinamicos_no.Add(e);
    }
    numeros_dinamicos_no.RemoveAt(numeros_dinamicos_no.Count - 1);
    Console.WriteLine("Elementos introducidos:");
		foreach(int el in numeros_estaticos){
			Console.WriteLine(el);
		}

  }
}	