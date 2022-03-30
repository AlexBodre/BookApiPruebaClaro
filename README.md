# BookApiPruebaClaro
Prueba tecnica Claro

En la carpeta Backend esta el api que consume el fake api, devuelve un onjeto tipo ServerResponse que captura el statusCode, la data, y un mensaje acorde
a la operacion que se este relizando.

Los endpoints son los mismos que fueron requeridos en las instrucciones, para iniciar la applicacion deben ejecutar la solucion c# ubicada en el
folder Backend.

Para el backend utilicé .Net 5


El frontend fue construido en Angular y estilizado con Bootstrap (No soy muy diseñador que digamos) 
Tiene 3 components: create, detail, list

En el list, podemos ver todos los libros, podemos seleccionar uno para acceder al detalle, podemos eliminar un registro y podemos filtrar por id
En el create tenemos el Books/Add donde podemos agregar un nuevo libro
En el details tenemos el Books/id donde podemos ver en detalle un libro y tambien modificarlo (Books/id)


