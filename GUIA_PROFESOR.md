# ComePuntos — Guía del profesor

Una mini web estilo Duolingo para aprender **C# básico armando un videojuego**. El juego ya
está hecho, pero le faltan 10 piezas. Cada lección enseña un concepto de C# y al final el
alumno **escribe en C# la pieza que falta**. El juego se actualiza **en vivo** mientras
escribe. Al terminar, el alumno copia su código a un proyecto real de **Visual Studio** y
juega su juego en la consola.

## Cómo usarla

- **En línea:** https://claude.ai/artifact/BFm4vVEgJBqMSgwmsG93Re (compártela con los alumnos
  desde el menú *Share* de la página).
- **Sin internet:** abre `index.html` con doble clic en **Chrome o Edge**.
- El progreso (XP, racha, lecciones y código) se guarda **en ese navegador y esa computadora**.
- **Modo profesor:** agrega `#profe` al final de la dirección. En los ejercicios de código
  aparece el botón **👩‍🏫 Ver solución**, útil para resolver en vivo en el proyector.

### ¿Cómo corre C# en el navegador?

El navegador no ejecuta C#. La web incluye un **revisor de C#** para el subconjunto del curso
(`int`, `string`, `char`, `bool`, `if`, `for`, `while`, `foreach`, métodos, arreglos, `char[,]`,
`Random`, `Math`, `Console.WriteLine`). El revisor detecta los errores típicos de principiante
y los explica en español, con número de línea y el código de error de C#:

| Error del alumno | Mensaje |
|---|---|
| Falta `;` | CS1002 |
| `casilla == "#"` con `casilla` de tipo `char` | CS0019: usa comillas simples |
| `'arriba'` con comillas simples | CS1012: un char es UNA letra |
| `if (x = 5)` | CS0029: dentro del if se compara con `==` |
| `return "true";` en un método `bool` | El método devuelve bool |
| Variable sin declarar | CS0103 |
| `let`, `===`, `Math.abs`, `.length`, `True` | Explica cómo se escribe en C# |
| Ciclo infinito | Lo detiene y avisa |

Después, el código se traduce para que corra en el navegador. La prueba final es el
**proyecto de Visual Studio** (`proyecto-csharp/`), donde compila el C# real.

## Cómo funciona una lección

| Tipo | Qué hace el alumno |
|---|---|
| 📖 Aprende | Lee una explicación corta con ejemplos en C# |
| ✅ Elige | Opción múltiple (¿qué da este código?) |
| 🧩 Completa el código | Toca fichas para llenar los huecos |
| 🗺️ Completa el diagrama | Llena un diagrama de flujo con fichas |
| 🔀 Ordena | Arma un método poniendo las líneas en orden |
| 🤖 Usar bien la IA | Elige el mejor mensaje, encuentra el error en código de la IA o escribe su propio mensaje |
| 💻 Escribe la pieza en C# | Escribe el método; las pruebas automáticas y el juego le muestran si funciona |

Como en Duolingo: hay **5 corazones** por lección (un error en opción, fichas u orden cuesta
uno), los ejercicios fallados se repiten al final, y cada lección da **XP** y suma a la
**racha**. Escribir código o mensajes para la IA **no** quita corazones.

## Las 10 lecciones

| # | Lección | Concepto de C# | Método que escriben | Ejercicio de IA |
|---|---|---|---|---|
| 1 | Variables y tipos | `int`, `string`, `char`, `bool` | `velocidad`, `vidasIniciales`, `colorJugador` | Elegir el mejor mensaje |
| 2 | Decisiones: if | `if / else if`, `==` vs `=` | `string ColorDeCasilla(char)` | Pedir explicación sin que resuelva |
| 3 | Métodos | tipo de retorno, parámetros, `return` | `int SiguienteFila/SiguienteColumna(int, string)` | Encontrar el error de la IA |
| 4 | bool | `true / false` | `bool EsPared(char)` | No compartir datos personales |
| 5 | Números | operaciones, `+=` | `int PuntosDeCasilla(char)` | Pegar el error exacto (CS0019) |
| 6 | Ciclos for | `for` anidado, `char[,]`, `GetLength` | `int ContarPuntos(char[,])` | Encontrar el `return` mal puesto |
| 7 | Azar y arreglos | `Random.Next`, `.Length` | `string DireccionAlAzar(string[])` | La IA inventa cosas: comprobar |
| 8 | Y / O | `&&`, `\|\|` | `bool HayChoque(int, int, int, int)` | Pedir casos de prueba, no código |
| 9 | Distancia | `Math.Abs` | `int Distancia(int, int, int, int)` | Encontrar el `Math.Abs` que falta |
| 10 | Buscar el mejor | buscar el mínimo | `int IndiceDelMenor(int[])` | Pedir que se adapte a tu nivel |

La IA de los ejercicios es **simulada**: responde de forma vaga o útil según qué tan completo
es el mensaje. Después se puede pedir que repitan el mismo mensaje con una IA real y comparen.

## El proyecto de Visual Studio (`proyecto-csharp/`)

- Abre `ComePuntos.csproj` (necesita .NET 8 o más nuevo) y presiona **F5**.
- `Program.cs` usa *top-level statements*: arriba va el código del alumno (entre
  `PEGA AQUÍ TU CÓDIGO` y `FIN DE TU CÓDIGO`) y abajo el motor del juego, que llama a sus métodos.
- Viene con el código **inicial** de cada lección: compila y corre, pero le faltan piezas.
- Al terminar en la web, el alumno toca **📋 Copiar mi código**, lo pega entre las marcas y
  juega en la consola.
- `dotnet run -- --prueba` juega solo, sin pantalla, y muestra el resultado (útil para revisar).

## Sugerencias para la clase

- Primera sesión: haz la lección 1 completa en el proyector y deja que vean un error a propósito.
- Una lección dura entre 10 y 20 minutos. Con sesiones de 50 min caben 2 o 3 lecciones.
- Trabajar en parejas funciona muy bien: uno lee y el otro escribe, y cambian en cada lección.
- Al terminar cada lección, pide a alguien que lea su código **en voz alta y en español**
  (`if (vidas <= 0)` → «si las vidas son cero o menos…»).
- Cierre: que corran su código en Visual Studio. Ver su juego en una consola real es la recompensa.

## Para editar o agregar lecciones

Todo vive en `index.html`. Las lecciones están en el arreglo `UNIDADES`, dentro del bloque
`<script id="datos">`. En los huecos y diagramas, `[[correcta|distractor|distractor]]` crea
un hueco con sus fichas. Cada ejercicio de código trae `inicial`, `solucion`, `pistas` y `test`.
`publicar/comepuntos.html` es la copia que se publica en línea (es `index.html` sin las
etiquetas `<html>`, `<head>` y `<body>`).
