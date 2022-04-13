
# Resumen.
 En este proyecto me encargué de desarrollar la estrategia de defensa del BOT al jugar contra el usuario.
 
## Implementación
  Para la implementación hago uso de una estructura de Árbol, utilizando recorridos recursivos, y también iterativos según los requiera.
 
## Métodos Implementados en la Clase Estrategia.
1. CalcularMovimiento (ArbolGeneral<Planeta> arbol): Este método calcula y retorna el movimiento apropiado según el estado del juego. El estado del juego es recibido en el parámetro arbol de tipo ArbolGeneral<Planeta>. Cada nodo del árbol contiene como dato un planeta del juego.
2. Consulta1 (ArbolGeneral<Planeta> arbol): Calcula y retorna un texto con la distancia que existe entre la raíz y el nodo del árbol que es enviado como parámetro que contiene el planeta más cercano perteneciente al Bot.
3. Consulta2 (ArbolGeneral<Planeta> arbol): Calcula y retorna en un texto la cantidad de planetas que tienen población mayor a 10 en cada nivel del árbol que es enviado como parámetro.
4. Consulta3 (ArbolGeneral<Planeta> arbol): Calcula y retorna en un texto el promedio poblacional por nivel del árbol que es enviado como parámetro.

## Descripción del juego.
Este es un juego de computadora que se desarrolla como una conquista planetaria donde el enfrentamiento se da únicamente entre dos jugadores. Estos últimos están representados por el usuario y por una entidad de software que posee codificada cierta estrategia destinada a ganar el juego (Bot). El objetivo del juego es apoderarse de todos los planetas del rival. Es un juego basado en turnos, en donde los participantes disponen de un número de turnos determinado para conseguir la victoria. En cada turno, los planetas que se muestran en pantalla, albergan una cantidad específica de naves que pueden pertenecer al jugador, al oponente o ser neutrales. La propiedad está representada por un color asignado a cada jugador, a saber: rojo para el usuario, azul para el Bot y blanco para indicar neutralidad. Además, cada planeta tiene un conjunto de rutas interplanetarias que los interconecta y que sirven para enviar flotas de un planeta hacia otro. Además los planetas cuentan con una tasa de crecimiento que indica cuantas naves pueden generar durante cada asalto, que luego serán agregadas a la flota que el jugador posee en el planeta. Los planetas neutrales no agregan nuevas naves a la flota que alojan hasta que sea conquistado por algún jugador.
Cada jugador se implementa como un agente de software que, a partir de una lista de planetas y sus flotas (el estado actual del mapa), devuelve una acción a realizar. En cada turno, se debe elegir el movimiento que realizará una flota que partirá de un planeta propio a cualquier otro planeta destino, pudiendo ser este último propio o no. Los movimientos serán posibles siempre y cuando exista una ruta interplanetaria directa entre un origen y un destino. Las flotas, pueden necesitar más de un turno para llegar a su planeta de destino (el tiempo es directamente proporcional a la distancia entre los planetas). Cuando la flota llega un planeta enemigo o neutral, tiene lugar un enfrentamiento, en el cual cada nave es sacrificada para destruir una nave enemiga, en otras palabras, resulta victoriosa aquella flota que albergue más naves. En caso de que el planeta de destino sea del propio jugador, ambas flotas se unen, sumando sus naves. En cada turno, el número de naves alojadas en los planetas de los jugadores (no los neutros), se incrementa de acuerdo a la tasa decrecimiento de cada planeta.


