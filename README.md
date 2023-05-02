# Proto_Script

/*TowerAmongus*/


-Sebastian Franco.

-Emmanuel Echeverri. 

-Jose Miguel lopez.

-Juan Seabstian Correa.

Link de ejecutable
https://drive.google.com/drive/folders/1iMLkQ6OA9d02P2QJZwXQqohnDA-vs5nX?usp=sharing

Cambios hechos al proyecto.
- Cambios de logica en el Spaceship

Cambios del tercer avance
- Implementación al proyecto dentro de Unity, esta vez teniendo game objects y unos nuevos scripts más orientados a Unity
- Se tiene un gameObject vacío donde tal contiene un script llamado SpaceMovementGrid, el cual asigna contiene varios arreglos e inicializa uno donde va a poder guardar la información de los objectos
- SpaceMovementGrid también contiene un método que comparará posiciones de dos arreglos diferentes, el cual va a ver si en esa posición en los dos arreglos habrá un 1, si es verdadero (Dependiendo si es Enemy o Object) entonces va a destruir el gameObject correspondiente y cambiará cierta variable en el script específico del Player
- El Player, el Enemy y el ObjectBonus, en cada uno de estos scripts se inicializará un arreglo especifico para esa clase, uno donde guardará la posición del script y otro en el que guardará la posición como si fuera un char entre 0 y 1, de manera que se sepa en donde está ubicado el gameObject correspondiente
- Tanto el SpaceMovementGrid como el Player/Enemy/ObjectBonus van a calcular dependiendo del ancho y altura de la cámara, un espacio en específico, el cual determinará la posición inicial. Y para el Player, calculará cuanto se va a mover para cumplir el movimiento en el arreglo de manera gráfica
- Implementación de menús en diferentes escenas, las cuales como el Pause permitirán moverse entre el menú principal y el menú de pausa
- Cuando el Player es eliminado o el Enemy es eliminado, entonces mostrará una pantalla de si ganó o perdió que lo enviará al menú principal
- Intento de implementación del patrón de Factory
