# SEGUNDO_PARCIAL_LABO_II
Segundo parcial de Laboratorio II de Perez Cardenal Patricio

# [EL TTTRUCO]
---
## []-| SOBRE MI.
Mi nombre es Perez Cardenal Patricio, tengo 18 años, soy estudiante de programacion en la UTN. En comparacion con el primer trabajo he de decir que este me ha parecido mas simple, si bien la logica de la aplicación fue algo dificil de desarrollar debido a las diversas variantes que posee el truco, me ha sido mucho mas divertido puesto que la creacion de videojuegos me llama mucho la atencion. Tambien cabe mencionar que encuentro mucho entretenimiento en el apartado estetico de cualquier produccion.
## []-| RESUMEN.
- [LOGION Y SIGN IN] La aplicacion comienza con una ventana de LOG-IN que permite al jugador ingresar su usario y contraseña (La misma posee un OJO que permite desocultarla para poder verificar que este correcta) para entrar con su respectivo perfil. En el mismo formulario tambien podremos registrar diferentes usuarios.
- [MENU PRINCIPAL] Una vez ingresado con el perfil correspondiente podremos observar los diferentes apartados:
     - *INICIO*: Aqui podremos observar una interfaz que muestra el nombre del usuario logueado con sus respectivas estadisticas de juego.
     - *JUGAR*: Por este otro lado, tendremos una interfaz que nos mostrara en forma de lista las salas creadas, de esta manera podremos entrar en una para comenzar a jugar.
     - *ESTADISTICAS*: Esta otra opcion, similar a la anterior, nos mostrara un listado de los usuarios registrados en la aplicacion. Del mismo modo, podremos acceder a las estadisticas individuales de cada uno.
     - *CREAR SALA*: Por ultimo, aqui tendremos la opcion que nos permitira crear salas, tantas como querramos. En el lado derecho tendremos un contador con la fecha y hora en tiempo real debido a que la partida tomara registro de cuando fue creada.
- [JUEGO] En la partida tendremos dos lados, la interfaz general, la cual esta ubicada en el margen superior del formulario en la que podremos observar toda la informacion de la partida y la interfaz del jugador. En esta ultima tendremos los diferentes botones que nos permitiran accionar en el juego y las cartas que posee el usuario en cuestion.

## []-| DIAGRAMA DE CLASES.

## []-| DIAGRAMA DE BASE DE DATOS.

## []-| JUSTIFACION TECNICA.

- *EXCEPCIONES*
La utilizacion de excepciones me permitio prevenir aquellos problemas que podrian aquejar a la experiencia del usuario. Por otro lado tambien me fue util para mostrar las cartas en el apartado grafico, ya que una vez tirada determinada carta la misma seria eliminada (IGUALADA A NULL) del mazo y por lo tanto al querer volver a mostrarla esto corromperia el programa.

- *PRUEBAS UNITARIAS*
He utilizado las pruebas unitarias para corroborar y verificar el buen funcionamiento de la logica de los metodos implementados.

- *INTERFACES Y GENERICOS*
He creado una interfaz con parametros genericos para implementarlo en la conexion de las tres diferentes tablas de la base de datos.

- *ESCRITURA DE ARCHIVO Y SERIALIZACION JSON*
He realizado una escritura en un archivo de tipo JSON con todas las cartas existentes del truco para luego poder deserializarlas en un mazo y que se facilite la tarea de repartir.

- *BASE DE DATOS Y SQL*
Implementacion caracteristica a diferencia del trabajo anterior. En este trabajo he podido guardar la informacion en una base de datos imposibilitando la perdida de informacion y estructurando la misma en diferentes tablas manejadas con PRIMARY KEY y realacionadas con FOREIGN KEY todas ID identity para dara mas seguridad al acceso de las mismas.

- *DELEGADOS*
Implemente delegados en conjunto con los HILOS y los EVENTOS.

- *EVENTOS*:
He creado un evento que se accionara al hacer click en un boton. Pero, a diferencia del evento original, este tendra la posibilidad de retornar un valor booleanoo que luego facilitara el manejo de la logica del juego.

- *MULTI-HILO - TASK*
He utilizado la programación multi-hilo para poder crear salas en hilos indepedientes y que los mismos no afecten al uso paralelo del programa. Tambien cree un TIMER  a tiempo real que fue implementado con multi-hilo para que el mismo no este sobrecargando el hilo principal.