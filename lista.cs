
using System;
using System.Collections.Generic;

namespace Tarea1
{
  public class Lista 
	{ 
		//Lista
    public List<string> elementos = new List<string>();

		//Mostrar contenido de la lista
		public void MostrarElementos()
		{
			Console.WriteLine("\n   Lista actualizada. Contenido actual:\n");
			foreach(string elemento in elementos)
			{
				Console.WriteLine("\t -{0}", elemento);
			}
			Console.WriteLine("\n");
		}

		//Agregar elmento 
		public void AgregarElemento(string elem)
		{
			elementos.Add(elem);			
		}

		//Agregar elemento primera posición
		public void AgregarElementoPrimero(string elem)
		{
			elementos.Insert(0, elem);			
		}

		//Insertar un elemento a partir de otro
		public void AgregarElementoDespuesDeOtro(string elemNuevo, string elemExistente)
		{
			//Obtener posición del elemento elemExistente
			int indexElem = elementos.FindIndex(x => x == elemExistente);
			//Insertar elemNuevo en la siguiente posición
			if(indexElem == -1)
			{
				Console.WriteLine("\nERROR: El elemento {0} no se encuentra en la lista.\n", elemExistente);
			}
			else
			{
				elementos.Insert(indexElem + 1, elemNuevo);
			}			
		}

		//Buscar elemento
		public void buscarElemento(string elem){
			string result = elementos.Find(x => x == elem);
			if(result != null)
			{
				Console.WriteLine("Encontrado. El elemento {0} existe en la lista.", elem);
			}
			else
			{
				Console.WriteLine("\nERORR: No se encontró '{0}' en la lista de elementos\n", elem);
			}
			
		}

		//Eliminar elemento por posición
		public void eliminarElemento(int indice)
		{
			try
			{
				string eliminado = elementos[indice];
				elementos.RemoveAt(indice);
				Console.WriteLine("El elemento '{0}' fue eliminado.", eliminado);
			}
			catch(Exception e)
			{
				Console.WriteLine("Ocurrió un error. Detalles: {0}", e.Message);
			}
		}

		//Eliminar elemento
		public void eliminarElemento(string elem)
		{
			try
			{
				string eliminado = elem;
				elementos.Remove(elem);
				Console.WriteLine("El elemento '{0}' fue eliminado.", eliminado);
			}
			catch(Exception e)
			{
				Console.WriteLine("Ocurrió un error. Detalles: {0}", e.Message);
			}
		}

  }
}
