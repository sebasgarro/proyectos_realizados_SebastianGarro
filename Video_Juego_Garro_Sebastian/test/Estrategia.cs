
using System;
using System.Collections.Generic;
namespace DeepSpace
{

	class Estrategia
	{
	
		Planeta DestinoParaAtacar; //Variable que se actualiza por cada llamada a EncontrarOrigenDestino(arbolIA)
		Planeta OrigenParaAtacar;  // """
		ArbolGeneral<Planeta> nodriza; //Se guardara por unica vez el arbol IA nodriza
		int distanciaMayor;
	
		
		public void EncontrarMayorDistancia(ArbolGeneral<Planeta> arbol,int nivel){
			if(arbol.getHijos().Count>0){
				foreach(ArbolGeneral<Planeta> planeta in arbol.getHijos()){
					EncontrarMayorDistancia(planeta,nivel+1);
				}
			}
			else{
				if(nivel>distanciaMayor){
					distanciaMayor=nivel;
				}
			}
		}
		
		public String Consulta1( ArbolGeneral<Planeta> arbol)
		{
			EncontrarMayorDistancia(arbol,0);
			
			return "La distancia mayor entre el Planeta Origen y un Planeta Hoja es: "+distanciaMayor;
		}

		public int EncontrarPlanetasHojasConPoblacionMayor3(ArbolGeneral<Planeta> arbol){
			Cola<ArbolGeneral<Planeta>> PlanetasPorRecorrer = new Cola<ArbolGeneral<Planeta>>();
			int CantidadPlanetasHojaPoblacionMayor3=0;
			PlanetasPorRecorrer.encolar(arbol);
			while(!PlanetasPorRecorrer.esVacia()){
				ArbolGeneral<Planeta> planetaActual=PlanetasPorRecorrer.desencolar();
				if(planetaActual.getHijos().Count==0 && planetaActual.getDatoRaiz().Poblacion()>3){
					CantidadPlanetasHojaPoblacionMayor3++;
				}
				foreach(ArbolGeneral<Planeta> planetaHijo in planetaActual.getHijos()){	
					PlanetasPorRecorrer.encolar(planetaHijo);
				}
			}
			return CantidadPlanetasHojaPoblacionMayor3;
		}

		public String Consulta2( ArbolGeneral<Planeta> arbol)
		{
			int PlanetasConPoblacionMayorA3=EncontrarPlanetasHojasConPoblacionMayor3(arbol);
			return "La cantidad de Planetas Hojas con Poblacion Mayor a 3 es: "+PlanetasConPoblacionMayorA3;
		}
		
		public double GetPoblacionPromedio(ArbolGeneral<Planeta> arbol){
			Cola<ArbolGeneral<Planeta>> PlanetasPorRecorrer = new Cola<ArbolGeneral<Planeta>>();
			double poblacionTotal=0;
			int cantidadPlanetas=0;
			PlanetasPorRecorrer.encolar(arbol);
			while(!PlanetasPorRecorrer.esVacia()){
				ArbolGeneral<Planeta> planetaActual=PlanetasPorRecorrer.desencolar();
				poblacionTotal+=planetaActual.getDatoRaiz().Poblacion();
				cantidadPlanetas++;
				foreach(ArbolGeneral<Planeta> planetaHijo in planetaActual.getHijos()){	
					PlanetasPorRecorrer.encolar(planetaHijo);
				}
			}
			return poblacionTotal/cantidadPlanetas;
		}
		
		public int[] GetCantidadPlanetasPorNivelesConPoblacionMayorAPromedio(ArbolGeneral<Planeta> arbol, double poblacionPromedio){
			EncontrarMayorDistancia(arbol,0);
			int cantidadNiveles=distanciaMayor+1;
			Cola<ArbolGeneral<Planeta>> PlanetasPorRecorrer = new Cola<ArbolGeneral<Planeta>>();
			int[] cantidadPlanetasPorNiveles = new int[cantidadNiveles];
			int posicionNivel=0;
			PlanetasPorRecorrer.encolar(arbol);
			while(!PlanetasPorRecorrer.esVacia()){
				int cantidadPlanetas = PlanetasPorRecorrer.cantidadElementos();
				int cantidadPlanetasEnNivel=0;
				while(cantidadPlanetas-->0){
					ArbolGeneral<Planeta> planetaActual=PlanetasPorRecorrer.desencolar();
					if(planetaActual.getDatoRaiz().Poblacion()>poblacionPromedio){
						cantidadPlanetasEnNivel++;
					}
					foreach(ArbolGeneral<Planeta> planetaHijo in planetaActual.getHijos()){	
						PlanetasPorRecorrer.encolar(planetaHijo);
					}
				}
				if(posicionNivel<cantidadNiveles){
					cantidadPlanetasPorNiveles[posicionNivel]=cantidadPlanetasEnNivel;
					posicionNivel++;
				}
			}
			return cantidadPlanetasPorNiveles;
		}
		
		public static double CantidadDecimales(double valor,int decimales){ //Funcion para redondear el valor al mostrarlo en la Consulta3
			double variableConvierteAPotencia = Math.Pow(10,decimales);
			return Math.Truncate(valor*variableConvierteAPotencia)/variableConvierteAPotencia;
			
		}


		public String Consulta3( ArbolGeneral<Planeta> arbol)
		{
			double poblacionPromedio= GetPoblacionPromedio(arbol);
			int[] cantidadPlanetasPorNivel=GetCantidadPlanetasPorNivelesConPoblacionMayorAPromedio(arbol,poblacionPromedio);
			string textoDatos="Cantidad de planetas por nivel cuya población supera el promedio("+CantidadDecimales(poblacionPromedio,2)+"): \n";
			for(int nivel=0;nivel<cantidadPlanetasPorNivel.Length;nivel++){
				textoDatos+="Nivel "+nivel+": "+cantidadPlanetasPorNivel[nivel]+" Planetas\n";
				
			}
			return textoDatos;
		}
		
		public Movimiento CalcularMovimiento(ArbolGeneral<Planeta> arbol)
		{
			//Encontramos la IA Nodriza por unica vez
			if(nodriza==null){
				nodriza=EncontrarIANodriza(arbol);
			}
			//Hacemos las busquedas de planetas solo en el arbol de la IA nodriza, asi ahorramos tiempo de busqueda
			EncontrarOrigenDestino(nodriza);
			//OrigenParaAtacar y NeutroParaAtacar son seteados en EncontrarOrigenDestino(arbol) 
			return new Movimiento(OrigenParaAtacar,DestinoParaAtacar);
			
		
		
		}
		
		
		//Usaremos este método para optimizar la busqueda en EncontrarOrigenDestino(arbolIA)
		//Ya que una vez encontrada la IA Nodriza, toda nuestra busqueda posterior sera dentro de sus descendientes, por lo que no necesitamos del arbol de todo el juego 
		public ArbolGeneral<Planeta> EncontrarIANodriza(ArbolGeneral<Planeta> arbol){
			Cola<ArbolGeneral<Planeta>> PlanetasPorRecorrer = new Cola<ArbolGeneral<Planeta>>();
			PlanetasPorRecorrer.encolar(arbol);
			while(!PlanetasPorRecorrer.esVacia()){
				ArbolGeneral<Planeta> planetaActual=PlanetasPorRecorrer.desencolar();
				//Condicion para determinar si el planeta es IA Nodriza
				if(planetaActual.getDatoRaiz().EsPlanetaDeLaIA()){
						return planetaActual;
					}
				foreach(ArbolGeneral<Planeta> planetaHijo in planetaActual.getHijos()){
					//Condicion para determinar si el planeta es IA Nodriza
					if(planetaHijo.getDatoRaiz().EsPlanetaDeLaIA()){
						return planetaHijo;
					}
					
					PlanetasPorRecorrer.encolar(planetaHijo);
				}
			}
			return null;
		}
		
		
		
		
		public void EncontrarOrigenDestino(ArbolGeneral<Planeta> arbolIA){
			//booleano para usar el momento de Reagruparse, para hacer un break cuando encuentra al planeta origen con mayor proriedad de reagrupacion(basado en la poblacion)
			bool OrigenReagrupacionEncontrado=false;
			//Encuenta los planetas origen y destino para el ataque y los guarda en las variables estaticas NeutroParaAtacar y OrigenParaAtacar
			Cola<ArbolGeneral<Planeta>> PlanetasPorRecorrer = new Cola<ArbolGeneral<Planeta>>();
			PlanetasPorRecorrer.encolar(arbolIA);
			while(!PlanetasPorRecorrer.esVacia()){
				ArbolGeneral<Planeta> planetaActual=PlanetasPorRecorrer.desencolar();
				foreach(ArbolGeneral<Planeta> planetaHijo in planetaActual.getHijos()){
					//Condicion para determinar los planeta origen y destino para la CONQUISTA
					if(planetaHijo.getDatoRaiz().EsPlanetaNeutral() && planetaActual.getDatoRaiz().EsPlanetaDeLaIA()){
						DestinoParaAtacar = planetaHijo.getDatoRaiz();
						OrigenParaAtacar=planetaActual.getDatoRaiz();
					}
					
					//Verificamos que ya hubo conquistas 
					if(OrigenParaAtacar!=null && DestinoParaAtacar!=null){
						//Condicion para determinar los planeta origen y destino para la REAGRUPACION
						//Segun la POBLACION le damos prioridad al planeta para enviar tropas, el valor se determinó analizando los tiempos entre disparos y aumento de poblacion en modo de ejecucion del juego. Dando poblacion minima de 36 para que la reagrupacion sea aproximadamente equitativa
						if(OrigenParaAtacar.EsPlanetaDeLaIA() && DestinoParaAtacar.EsPlanetaDeLaIA() && planetaHijo.getDatoRaiz().EsPlanetaDeLaIA() && planetaActual.getDatoRaiz().EsPlanetaDeLaIA() && planetaHijo.getDatoRaiz().Poblacion()>80 ){
							DestinoParaAtacar = planetaActual.getDatoRaiz();
							OrigenParaAtacar=planetaHijo.getDatoRaiz();
							//Encontramos un planeta con poblacion mayor a 80, asi que queremos detener la busqueda
							OrigenReagrupacionEncontrado=true;
							
						}
						else if(OrigenParaAtacar.EsPlanetaDeLaIA() && DestinoParaAtacar.EsPlanetaDeLaIA() && planetaHijo.getDatoRaiz().EsPlanetaDeLaIA() && planetaActual.getDatoRaiz().EsPlanetaDeLaIA() && planetaHijo.getDatoRaiz().Poblacion()>36 ){
							DestinoParaAtacar = planetaActual.getDatoRaiz();
							OrigenParaAtacar=planetaHijo.getDatoRaiz();
						}
						
					
						
					}
					if(OrigenReagrupacionEncontrado) break;
					PlanetasPorRecorrer.encolar(planetaHijo);
				}
				
				if(OrigenReagrupacionEncontrado) break;
	
			}
		}
		
		
		
	}
}
