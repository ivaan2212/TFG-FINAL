# VrTemplateUMK
##### This is a DEMO1 for 3In

#### FUNCIONALIDADES IMPLEMENTADAS Y CONDICIONES A DESARROLLAR

  **15/04**

- Se pueden conectar cuantos jugadores se quiera utilizando el paquete **PARRELSYNC**, clonando proyectos e inicianizándolos.

- Sin embargo al realizar esto, ambos jugadores empezarán con **PLAYER1**, es decir; instanciando el jugador Nº1 en el spawnpoint predeterminado, no el **PLAYER2**. Visualizando el proyecto de *DEMO UMK* no logro adaptar dicha funcionalidad de instanciar elementos del juego por separado. Se tendrá que realizar una escena o canvas en el que me permita una especie de **"LOGIN"** al juego, y gracias a este login dar paso a una serie de ventanas en las que pueda tener diferentes opciones, como crear sala, unirse a una sala o quitar el juego.

- Sendos jugadores poseen la capacidad de moverse por todo el escenario (Escenario que quedan por hacer 2 salas y que cuyo contenido dentro de estas serán los puzzles) a la vez que cambiar el sprite de movimiento dependiendo del eje en el que se sitúen.
  
- He seguido realizando sprites acerca de estas 2 salas contiguas. En el centro de la sala principal ambos jugadores tendrán que ponerse de acuerdo para dar un resultado numérico en una plataforma. Para ello, se tendría que añadir una funcionalidad de chat de texto para ambos jugadores.

 **16/04**
 
 - Hoy dia he ultimado los detalles de alguno de los sprites que hay que realizar en las habitaciones mencionadas antes. Habrá una librería con distintos tipos de libros.
   
 - Aparte he tenido en cuenta agregar una iluminación (bastante simple) para dar más ambiente a la escena.
   
 - El canvas sigue haciéndose pues tengo en cuenta parte del código de la **"DEMO UMK"** no consigo comprenderlas, pues el paquete Photon no tengo mucho contacto con este y dicho código hace referencia a bastantes métodos y funciones que no consigo entender. Parte de estas funcionalidades las estoy siguiendo de parte de documentación de Photon, parte de páginas de Unity y otras viendo guías en Youtube.

**17/04**

- Se ha seguido introduciendo sprites para las diferentes habitaciones. Se ha empezado a realizar el puzzle de los láseres. Estos sprites incluyen mesas y diferentes tipos de escritorios, esto con el fin de que los jugadores puedan interactuar con dichos elementos para que aparezcan en pantalla en canvas los diferentes puzzles a realizar. 

* Queda por decidir cómo guardar los dígitos a introducir para cada partida (se planea que sea un número aleatorio para cada partida)

**18/04**

* Se ha implementado el puzzle de láseres, sin embargo, se ha hecho en una escena diferente a la que se sitúa el juego completo. El puzzle es bastante fácil de resolver pues es asequible para todos los jugadores. El láser rebota correctamente con los diferentes elementos que actúan como 'espejo' dentro del canvas. 

* Lo único que quedaría introducir a este para terminar el puzzle es que cuando el láser interactúe con un elemento para terminar el juego, que lo detecte y que salte un canvas con diferentes opciones, pero la más importante es la de mostrar al jugador el número que tendrá que introducir junto con su compañero en la mitad de la sala online. 

**19/04**

* El puzzle del láser está totalmente listo. Se ha conseguido que el láser detecte el elemento final para que de paso a mostrar la solución numérica del puzzle, todo esto mediante un OnTriggerEnter. Los canvas también quedan hechos y cada puzzle está contenido dentro de estos. 

* Se ha optado por eliminar la escena del puzzle de láseres para que se quede dentro de la escena online.


**22/04**

* Se he implementado la interacción con las mesas. Ahora cuando te acercas a las mesas, el canvas en cuestión dependiendo de la mesa se abre al puzzle correspondiente.

* Se ha arreglado el puzzle de los láseres ya que no se visualizaba correctamente el láser cuando la escena se pasaba a un canvas. Queda por hacer que los "Espejos" se puedan rotar.


**23/04**

* Se ha implementado la funcionalidad de rotar todos los "Espejos" del puzzle de los láseres. Al colisionar con el elemento final para solucionar el puzzle, detecta la colisión mas no consigo hacer que se active un canvas que da paso al numero aleatorio generado. He intentado hacer referencia a distintos scripts de Comprobacion de colision una vez que el laser beam colision con la esfera, pero sin resultado.

* Del puzzle de simbolos, queda que el botón de comprobacion chequee que cada panel conste de una imagen y en caso de que posee una, comprobar si es la imagen correcta.

* Se ha mejora tema de visual, cambiado alguno de los sprites para que encajen más con la temática del videojuego.


**24/04**

* Gracias a la ayuda de un compañero he conseguido que la lógica del puzzle de simbolos sea bastante más sencilla de formular, por lo que el puzzle de los simbolos queda casi totalmente finalizado. El casi se debe a que hay una comprobación que sigo sin saber realizar. El puzzle consiste en lo siguiente: Hay 4 paneles y 4 imagenes, a cada panel le corresponde una imagen en específico (se te proporciona una pista para ello). El script de DragAndDropImage hace que las imágenes que tengan este código se pueda mover mediante el puntero pinchando sobre ellas. En este también se establece que si una imagen se posiciona sobre un panel y sueltas el click, se autocoloca en el centro del panel, sin embargo, puede ser cualquier panel. Para comprobar que el panel es el correcto, se usa una serie de variables booleanas, del 1 al 4, cuando la imagen se posiciona en el panel correcto, su estado pasa a ser 'true', pero el problema que no consigo resolver es que al quitar la imagen del panel, su estado sigue siendo 'true'.

* El puzzle de láseres sigue con el mismo problema. Se ha meditado la posibilida de pasar el código de LaserBeam.cs para que herede la clase de Monobehaviour, pero sin éxito.

* Queda la realizacion de las lobbys la cual se hará al final de la demo.

**25/04**

* Se ha finalizado por completo el puzzle de los simbolos. Faltaba que al comprobar las imágenes y que todas estas estuvieran en su panel correcto que aparezca un canvas advirtiendo de que se le ha asignado un numero generado aleatoriamente. Este múmero se ha intentado guardar en PlayerPrefs con un nombre: "NumeroAleatorio".

* Al estar inacabado el puzzle del láser se ha optado por realizar la finalización de la demo1 con un solo puzzle. Por ende, el canvas contenedor de un "puzzle final" se queda solo con 1 solo dígito.

* Al canvas final, se le ha asignado la capacidad de cambiar de números mediante 2 botones. Subiendo o bajando este cambiará hasta un rango limitado de 0 a 10. Abordando el tema del uso de PlayerPrefs no ha funcionado bien, asi que se ha obtado por hacer simples referencias a ambos script uno a otro para obtener el valor del número aleatorio generado. Con una simple comprobación mediante un botón se activa el canvas final el cual felicita al jugador y con un botón sale del juego.

* Quedan 2 cosas por realizar antes de dar por finalizada la demo1: - Realización de Rooms y unirse o crear estas. - Conseguir la total funcionalidad del láser y su respectiva activación del canvas al colisionar con la esfera final.
