using System;
using System.Collections.Generic;
using Tarea1;

class Program {	

	//Método principal del programa
  public static void Main (string[] args) {

		//Crear lista vacía
  	Lista miLista = new Lista();
		
		//Repetir programa hasta que se seleccione la opción salir
		bool repetir = true;	

		do {

			Console.WriteLine("************************************************************\n" +
					"\t\t\tEQUIPO 1 - SEMINARIO 1\n\nSELECCIONA UNA DE LAS SIGUIENTES OPCIONES:\n" +
					"1= Insertar un elemento en una lista vacía\n" +
					"2= Insertar un elemento en la primera posición de una lista\n" +
					"3= Insertar un elemento en la última posición de una lista\n" +
					"4= Insertar un elemento a continuación de uno dado\n" +
					"5= Buscar elementos en una lista\n" +
					"6= Eliminar el primer elemento de una lista\n" +
					"7= Eliminar un elemento dada la posición\n" +
					"8= Eliminar un elemento dado\n" +
					"************************************************************\n\n"+
					"TU SELECCIÓN:");

			string opcionSeleccionada = Console.ReadLine();
			pasosTarea1(opcionSeleccionada, miLista);

			//Preguntar al usuario si desea continuar
			Console.WriteLine("¿Deseas continuar? (Enter = Si, N = No)");
			string res = Console.ReadLine();
			
			//Si selecciona N o n, salir del programa.
			if(res == "N" || res == "n"){
				Console.WriteLine("\nGracias por utilizar el programa del equipo 1");
				repetir = false;
			}
		}while(repetir == true);  
	 	
  }

	//Pasos de la tarea
	public static void pasosTarea1(string opcionSeleccionada, Lista miLista)
	{
		string nuevoElemento;

		switch (opcionSeleccionada)
		{
			case "1": //Insertar un elemento en una lista vacía			 
				Console.WriteLine("1- INSERTAR UN ELEMENTO EN UNA LISTA VACÍA\n");
				Console.WriteLine("Digita un elemento para agregar a la lista:\n\t");
				nuevoElemento = Console.ReadLine();
				miLista.AgregarElemento(nuevoElemento);
				miLista.MostrarElementos();
				break;
				
			case "2": //Insertar un elemento en la primera posición

				Console.WriteLine("2- INSERTAR UN ELEMENTO EN LA PRIMERA POSICIÓN DE UNA LISTA\n");
				Console.WriteLine("Digita un elemento para agregar a la primera posición de la lista:");
				nuevoElemento = Console.ReadLine();
				miLista.AgregarElementoPrimero(nuevoElemento);
				miLista.MostrarElementos();
				break;

			case "3": //Insertar un elemento en una lista vacía

				Console.WriteLine("3- INSERTAR UN ELEMENTO EN LA ULTIMA POSICIÓN DE UNA LISTA\n");
				Console.WriteLine("Digita un elemento para agregar a la última posición de la lista:");
				nuevoElemento = Console.ReadLine();
				miLista.AgregarElemento(nuevoElemento);
				miLista.MostrarElementos();
				break;

			case "4": //Insertar un elemento despues de otro

				Console.WriteLine("4- INSERTAR UN ELEMENTO A CONTINUACIÓN DE UNO DADO\n");
				Console.WriteLine("Digita el nuevo elemento a agregar:");
				nuevoElemento = Console.ReadLine();
				Console.WriteLine("Digita el nombre del elemento a partir del cual se debe insertar:");
				string elemento = Console.ReadLine();
				miLista.AgregarElementoDespuesDeOtro(nuevoElemento, elemento);
				miLista.MostrarElementos();
				break;

			case "5": //Buscar elementos en una lista

				Console.WriteLine("5- BUSCAR ELEMENTOS EN UNA LISTA\n");
				Console.WriteLine("Digita el elemento que deseas buscar:");
				nuevoElemento = Console.ReadLine();
				miLista.buscarElemento(nuevoElemento);
				break;   

        case "6": //ELIMINAR EL PRIMER ELEMENTO DE UNA LISTA

        Console.WriteLine("6- ELIMINAR EL PRIMER ELEMENTO DE UNA LISTA\n"); 
				miLista.eliminarElemento(0);
				miLista.MostrarElementos();
        break;

        case "7": //ELIMINAR UN ELEMENTO DADO LA POSICIÓN

        Console.WriteLine("7- ELIMINAR UN ELEMENTO DADO LA POSICIÓN\n"); 
        Console.WriteLine("Digita el elemento que deseas Eliminar desde 0 hasta 2:");
        nuevoElemento = Console.ReadLine();
        miLista.eliminarElemento(Int32.Parse(nuevoElemento));
				miLista.MostrarElementos();
        break;

        case "8": //ELIMINAR UN ELEMENTO DADO

        Console.WriteLine("8- ELIMINAR UN ELEMENTO DADO\n");
        Console.WriteLine("Digita el elemento que deseas Eliminar:");
        nuevoElemento = Console.ReadLine();
         miLista.eliminarElemento(nuevoElemento);
				miLista.MostrarElementos();
        break;

        
        
		}	
	}
}