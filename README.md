14 de octubre de 2024

CONSIDERACIONES PARA QUIEN RETOME ESTE PROYECTO

Lo primero que hay que tener en cuenta es que el proyecto no estaba pensado para ser posteriormente compartido y, por tanto, tiene algunos "atajos" o "vicios" que habitualmente se evitan en códigos compartidos en un equipo o que están pensados para que lo retome un desarrollador posteriormente. Por ello, es posible encontrar algunos defectos de planteamiento que intentaré esbozar a continuación, con objeto de que quien lo remote sea capaz de continuar a partir de aquí con la mayor solvencia posible:

1) Es un proyecto Blazor (.NET) que usa MySQL como SGBD. En el archivo Program.cs se puede observar cómo se hace la cadena de conexión a MySQL. El usuario y la contraseña están almacenados como variables de entorno, por lo que esto habrá que introducirlo manualmente de forma previa tanto para las pruebas en local como para la producción en servidor. Se ha optado por variables de entorno como medida de seguridad. Además, en el archivo appsettings.json está el resto de la cadena de conexión. En realidad, tal y como está funcionará correctamente, siempre que el SGBD esté instalado y funcionando con una BD llamada "efept" y se hayan introducido valores de usuario y contraseña válidos como variables de entorno. Recomiendo obviar las migraciones y generarlas de nuevo, porque creo que hice bastantes cambios en el desarrollo en local y no llegué a subirlos a git. Se deberá tener en cuenta que la migración generada no es la "natural" para Blazor y puede que se le tenga que hacer alguna modificación pequeña o recurrir a métodos alternativos (de hecho, las que pueda haber solo son versiones antiguas y ya no funcionales, según recuerdo). En mi caso, opté por la generación de scripts .sql que luego ejecutaba en el SGBD. Esto último se puede hacer manualmente o con un sencillo script que automatice el proceso. Fue lo que mejor me funcionó.

2) El sistema de correo electrónico está funcional. Hay que tener en cuenta que en Program.cs se indica que el usuario y contraseña se obtenga también de variables de entorno y en appsettings.json, en la sección de Smtp, se indica el servidor y el puerto que se debe utilizar (está funcional para el caso concreto en el que estaba haciendo las pruebas, pero habrá que ajustarlo según el proveedor).

3) El CSS está en un único archivo no minificado ni optimizado, pues aún estaba en fase de desarrollo y por tanto todavía no estaba pulido. No obstante, para facilitar la localización de los estilos utilizados, sí que hay indicaciones en el propio archivo, a través de comentarios, de la sección a la que afectan los estilos descritos. Por otra parte, hay ciertos nombres de clases (tanto en el app.css como, por extensión, en los .razor) que no son completamente descriptivos, pues a veces, dado que no estaba pensado para ser compartido el código, simplemente reutilizaba clases previas con nombres que podrían no encajar por completo con el elemento afectado; esto, no obstante, se puede solucionar fácilmente modificando los nombres de las clases por otros más genéricos.

4) Tanto el front como el back están a medio hacer. Pero el front aún más, si cabe. A pesar de ser la parte más sencilla, fue a la que le dediqué menos tiempo, por lo que habrá que dedicar bastante tiempo a "poner todo bonito". El back está algo más avanzado en varias partes, como el sistema de logueo, de envío de correos electrónicos, el esquema básico para el panel de administración, el boceto de las entidades y servicios, etc. El funcionamiento del back se entenderá mucho mejor una vez que se hayan entendido los requerimientos del proyecto del cliente (cuestión ajena a los propósitos de estas anotaciones).

5) En el archivo ApplicationDbContext.cs hay, además de otras cuestiones, varios seeders al final del archivo. Está pensado para que se pueda ejecutar "en un clic" en cualquier máquina o servidor, de tal manera que no haya que introducir manualmente o en archivo aparte los contenidos requeridos por el cliente.

El resto de cuestiones presentes en el código se entenderán mejor una vez entendidos los requerimientos del proyecto por parte del cliente, entendido los cinco puntos mencionados arriba y adquirido cierta familiaridad con el código en general.

Obviamente, el desarrollador que continúe este código queda legitimado para hacer cualquier cambio, sea menor o mayor, de cualquier parte del proyecto y, además, podrá atribuirse su autoría total sin problema.
