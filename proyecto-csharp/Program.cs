// =========================================================================
//
//   C O M E P U N T O S   -   tu videojuego en C#
//
//   Cómo usarlo:
//   1. Termina las lecciones en la web de ComePuntos.
//   2. Al final, toca "Copiar mi código".
//   3. Pega tu código abajo, entre "PEGA AQUÍ TU CÓDIGO" y "FIN DE TU
//      CÓDIGO", reemplazando todo lo que haya en medio.
//   4. Presiona F5 (o el botón verde ▶). ¡Juega con las flechas!
//
//   Si no has terminado, lo que está abajo es el código INICIAL de cada
//   lección: el juego corre, pero le faltan piezas (igual que en la web).
//
// =========================================================================

using System;
using System.Threading;

Random azar = new Random();   // el generador de números al azar (lección 7)

// ========================== PEGA AQUÍ TU CÓDIGO ==========================

// ----- Lección 1: Variables y tipos (Velocidad, vidas y color) -----
// 📦 Cambia los valores y mira el juego →

int velocidad = 5;               // turnos por segundo (de 1 a 15)
int vidasIniciales = 3;          // vidas al empezar (de 1 a 9)
string colorJugador = "Yellow";  // prueba "Cyan", "Green", "Magenta", "Red"...

// ----- Lección 2: Decisiones: if (Colores del laberinto) -----
// Recibe: casilla → un char: '#', '.', 'o' o ' '
// Devuelve: el nombre del color para dibujarla (un string)
//   '#' → "Blue"    '.' → "White"    'o' → "Yellow"    otra → "Black"
// Colores: "Blue", "Cyan", "Green", "Magenta", "Red", "White",
//          "Yellow", "Gray", "DarkBlue", "DarkGreen", "DarkYellow"...

string ColorDeCasilla(char casilla)
{
    if (casilla == '#')
    {
        return "Blue";
    }
    // ✏️ agrega aquí un else if para '.' y otro para 'o'

    return "Black";
}

// ----- Lección 3: Métodos (Movimiento) -----
// Las direcciones son: "arriba", "abajo", "izquierda", "derecha"
// Subir = restar fila. Bajar = sumar fila.
// Izquierda = restar columna. Derecha = sumar columna.

int SiguienteFila(int fila, string direccion)
{
    if (direccion == "arriba")
    {
        return fila - 1;
    }
    // ✏️ ¿y si es "abajo"?

    return fila;
}

int SiguienteColumna(int columna, string direccion)
{
    // ✏️ igual que arriba, pero con "izquierda" y "derecha"

    return columna;
}

// ----- Lección 4: bool: verdadero o falso (Paredes sólidas) -----
// Recibe: casilla → '#', '.', 'o' o ' '
// Devuelve: true si es pared, false si no

bool EsPared(char casilla)
{
    // ✏️ escribe aquí tu if

    return false;
}

// ----- Lección 5: Números (Comer puntos) -----
// Recibe: casilla → '#', '.', 'o' o ' '
// Devuelve: cuántos puntos vale (un int)
//   '.' → 10      'o' → 50      otra → 0

int PuntosDeCasilla(char casilla)
{
    // ✏️

    return 0;
}

// ----- Lección 6: Ciclos for (Contar puntos y ganar) -----
// mapa es una tabla de char: mapa[fila, columna]
// mapa.GetLength(0) → cuántas filas hay
// mapa.GetLength(1) → cuántas columnas hay
// Devuelve: cuántas casillas tienen '.' o 'o'
// || significa "o":   if (a == 1 || a == 2)

int ContarPuntos(char[,] mapa)
{
    int contador = 0;

    for (int fila = 0; fila < mapa.GetLength(0); fila++)
    {
        // ✏️ escribe aquí el for de las columnas
        //    y adentro un if que sume 1 al contador

    }

    return -1; // ✏️ ¿qué debes devolver?
}

// ----- Lección 7: Azar y arreglos (Fantasmas que se mueven) -----
// opciones es un arreglo con las direcciones SIN pared, por ejemplo:
//   { "arriba", "izquierda", "derecha" }
// Devuelve: UNA de ellas, al azar.
// Ya existe:  Random azar = new Random();
//   azar.Next(0, 3)  → 0, 1 o 2 (el 3 NO sale)

string DireccionAlAzar(string[] opciones)
{
    // ✏️ 1) saca una posición al azar
    // ✏️ 2) devuelve lo que hay en esa posición

    return null; // null = "nada": el fantasma no se mueve
}

// ----- Lección 8: Y / O (&& ||) (Choques con fantasmas) -----
// Devuelve: true si están en la MISMA casilla, false si no.
// && significa "y"

bool HayChoque(int filaJugador, int columnaJugador, int filaFantasma, int columnaFantasma)
{
    // ✏️

    return false;
}

// ----- Lección 9: Distancia (Radar de fantasmas) -----
// Devuelve: cuántos pasos hay de (fila1, columna1) a (fila2, columna2)
//   distancia = |fila1 - fila2| + |columna1 - columna2|
// Math.Abs(x) quita el signo menos.

int Distancia(int fila1, int columna1, int fila2, int columna2)
{
    int difFilas = Math.Abs(fila1 - fila2);
    // ✏️ calcula difColumnas y devuelve la suma

    return 0;
}

// ----- Lección 10: Buscar el mejor (Fantasmas que persiguen) -----
// numeros es un arreglo de int, por ejemplo { 7, 3, 9 }
// Devuelve: la POSICIÓN del número más chico.
// Para { 7, 3, 9 } devuelve 1, porque numeros[1] es 3.

int IndiceDelMenor(int[] numeros)
{
    int mejor = 0; // por ahora, el mejor es el primero

    // ✏️ recorre el arreglo con un for
    //    si numeros[i] es menor que numeros[mejor], guarda i en mejor

    return mejor;
}

// =========================== FIN DE TU CÓDIGO ===========================


// #########################################################################
//  MOTOR DEL JUEGO (lo preparó el profesor). No necesitas cambiarlo,
//  pero puedes leerlo: aquí se usan TUS métodos (ColorDeCasilla,
//  SiguienteFila, EsPared, PuntosDeCasilla, ContarPuntos, ...).
// #########################################################################

string[] laberinto =
{
    "###################",
    "#o.......#.......o#",
    "#.##.###.#.###.##.#",
    "#.................#",
    "#.##.#.#####.#.##.#",
    "#....#...#...#....#",
    "####.###.#.###.####",
    "####.#.......#.####",
    "####.#.## ##.#.####",
    "#......#   #......#",
    "####.#.#####.#.####",
    "####.#.......#.####",
    "####.#.#####.#.####",
    "#........#........#",
    "#.##.###.#.###.##.#",
    "#o.#..... .....#.o#",
    "##.#.#.#####.#.#.##",
    "#....#...#...#....#",
    "#.######.#.######.#",
    "#.................#",
    "###################"
};
string[] direccionesPosibles = { "arriba", "abajo", "izquierda", "derecha" };
int filasMapa = laberinto.Length;
int columnasMapa = laberinto[0].Length;
char[,] tablero = new char[filasMapa, columnasMapa];

// El jugador
int jFila = 15, jColumna = 9;
string direccionActual = "", direccionDeseada = "";

// Los 4 fantasmas (arreglos paralelos: el fantasma g usa la posición g de cada arreglo)
int[] fFilaInicio = { 9, 9, 9, 7 };
int[] fColumnaInicio = { 8, 9, 10, 9 };
bool[] fPersigue = { true, false, true, false };   // el rojo y el cian te persiguen
ConsoleColor[] fColor = { ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Cyan, ConsoleColor.DarkYellow };
int[] fFila = new int[4];
int[] fColumna = new int[4];

// Estado de la partida
int juegoPuntaje = 0, juegoVidas = 0, juegoPausa = 0, juegoTurno = 0;
string juegoEstado = "jugando";   // "jugando", "gano", "perdio" o "salir"

// Pantalla: dibujamos en un "borrador" y solo escribimos lo que cambió (así no parpadea)
int altoPantalla = filasMapa + 3;
int anchoPantalla = Math.Max(columnasMapa * 2, 64);
char[,] pantalla = new char[altoPantalla, anchoPantalla];
ConsoleColor[,] colores = new ConsoleColor[altoPantalla, anchoPantalla];
char[,] pantallaAntes = new char[altoPantalla, anchoPantalla];
ConsoleColor[,] coloresAntes = new ConsoleColor[altoPantalla, anchoPantalla];

// "dotnet run -- --prueba" juega solo, sin pantalla, para revisar que todo funciona.
if (args.Length > 0 && args[0] == "--prueba")
{
    ProbarSinPantalla();
    return;
}

try { Console.OutputEncoding = System.Text.Encoding.UTF8; } catch (Exception) { }
try { Console.CursorVisible = false; } catch (Exception) { }
try { Console.Title = "ComePuntos"; } catch (Exception) { }

// ============================ EL GAME LOOP ============================
bool otraVez = true;
while (otraVez)
{
    ReiniciarJuego();
    while (juegoEstado == "jugando")
    {
        LeerTeclas();                 // 1. ¿qué tecla presionó el jugador?
        if (juegoEstado != "jugando") break;
        Paso();                       // 2. mover a todos y aplicar las reglas
        Dibujar();                    // 3. mostrar cómo quedó todo
        Thread.Sleep(1000 / Math.Clamp(velocidad, 1, 15));   // 4. esperar un poquito
    }
    if (juegoEstado == "salir") break;
    otraVez = PantallaFinal();
}
Console.ResetColor();
Console.Clear();
try { Console.CursorVisible = true; } catch (Exception) { }
Console.WriteLine("¡Gracias por jugar ComePuntos!");


// ======================== MÉTODOS DEL MOTOR ===========================

void ReiniciarJuego()
{
    for (int f = 0; f < filasMapa; f++)
        for (int c = 0; c < columnasMapa; c++)
            tablero[f, c] = laberinto[f][c];
    juegoPuntaje = 0;
    juegoVidas = Math.Clamp(vidasIniciales, 1, 9);
    juegoEstado = "jugando";
    juegoTurno = 0;
    ReiniciarPosiciones();
    juegoPausa = 0;
    for (int y = 0; y < altoPantalla; y++)
        for (int x = 0; x < anchoPantalla; x++)
            pantallaAntes[y, x] = '\0';
    Console.ResetColor();
    Console.Clear();
}

void ReiniciarPosiciones()
{
    jFila = 15; jColumna = 9;
    direccionActual = ""; direccionDeseada = "";
    for (int g = 0; g < 4; g++) { fFila[g] = fFilaInicio[g]; fColumna[g] = fColumnaInicio[g]; }
    juegoPausa = 10;
}

void LeerTeclas()
{
    while (Console.KeyAvailable)
    {
        ConsoleKey k = Console.ReadKey(true).Key;
        if (k == ConsoleKey.UpArrow || k == ConsoleKey.W) direccionDeseada = "arriba";
        else if (k == ConsoleKey.DownArrow || k == ConsoleKey.S) direccionDeseada = "abajo";
        else if (k == ConsoleKey.LeftArrow || k == ConsoleKey.A) direccionDeseada = "izquierda";
        else if (k == ConsoleKey.RightArrow || k == ConsoleKey.D) direccionDeseada = "derecha";
        else if (k == ConsoleKey.Escape) juegoEstado = "salir";
    }
}

// ¿Se puede avanzar desde (f, c) hacia "dir"? Usa TUS métodos.
bool PuedeIr(int f, int c, string dir, out int nf, out int nc)
{
    nf = SiguienteFila(f, dir);
    nc = SiguienteColumna(c, dir);
    if (nf == f && nc == c) return false;
    if (nf < 0 || nf >= filasMapa || nc < 0 || nc >= columnasMapa) return false;
    return !EsPared(tablero[nf, nc]);
}

void Paso()
{
    juegoTurno++;
    if (juegoPausa > 0) { juegoPausa--; return; }

    // El jugador gira si puede y avanza
    if (direccionDeseada != "" && PuedeIr(jFila, jColumna, direccionDeseada, out _, out _)) direccionActual = direccionDeseada;
    if (direccionActual != "" && PuedeIr(jFila, jColumna, direccionActual, out int nf, out int nc)) { jFila = nf; jColumna = nc; }

    // Come lo que hay en su casilla
    char casilla = tablero[jFila, jColumna];
    int puntos = PuntosDeCasilla(casilla);
    if (casilla != ' ' && puntos > 0) { juegoPuntaje += puntos; tablero[jFila, jColumna] = ' '; }

    // ¿Ya no quedan puntos? ¡Ganaste!
    if (ContarPuntos((char[,])tablero.Clone()) == 0) { juegoEstado = "gano"; return; }

    if (RevisarChoque()) return;
    if (juegoTurno % 2 == 0) { MoverFantasmas(); RevisarChoque(); }
}

bool RevisarChoque()
{
    for (int g = 0; g < 4; g++)
    {
        if (HayChoque(jFila, jColumna, fFila[g], fColumna[g]))
        {
            juegoVidas--;
            Console.Beep();
            if (juegoVidas <= 0) { juegoVidas = 0; juegoEstado = "perdio"; }
            else ReiniciarPosiciones();
            return true;
        }
    }
    return false;
}

void MoverFantasmas()
{
    for (int g = 0; g < 4; g++)
    {
        // Direcciones a las que SÍ puede ir este fantasma
        string[] dirs = new string[4];
        int[] destinoF = new int[4], destinoC = new int[4];
        int cuantas = 0;
        foreach (string d in direccionesPosibles)
        {
            if (PuedeIr(fFila[g], fColumna[g], d, out int nf, out int nc))
            {
                dirs[cuantas] = d; destinoF[cuantas] = nf; destinoC[cuantas] = nc; cuantas++;
            }
        }
        if (cuantas == 0) continue;
        string[] opciones = new string[cuantas];
        Array.Copy(dirs, opciones, cuantas);

        int elegida = -1;
        // Los perseguidores (3 de cada 4 turnos) eligen la opción más cercana al jugador
        if (fPersigue[g] && azar.Next(0, 4) != 0)
        {
            int[] distancias = new int[cuantas];
            bool todasIguales = true;
            for (int k = 0; k < cuantas; k++)
            {
                distancias[k] = Distancia(destinoF[k], destinoC[k], jFila, jColumna);
                if (distancias[k] != distancias[0]) todasIguales = false;
            }
            if (!todasIguales)
            {
                int k = IndiceDelMenor(distancias);
                if (k >= 0 && k < cuantas) elegida = k;
            }
        }
        if (elegida < 0) elegida = Array.IndexOf(opciones, DireccionAlAzar(opciones));
        if (elegida >= 0) { fFila[g] = destinoF[elegida]; fColumna[g] = destinoC[elegida]; }
    }
}

ConsoleColor AColor(string nombre, ConsoleColor siFalla)
{
    if (nombre != null && Enum.TryParse(nombre, true, out ConsoleColor c) && Enum.IsDefined(typeof(ConsoleColor), c)) return c;
    return siFalla;
}

void Escribir(int x, int y, char simbolo, ConsoleColor color)
{
    if (x < 0 || y < 0 || x >= anchoPantalla || y >= altoPantalla) return;
    pantalla[y, x] = simbolo;
    colores[y, x] = color;
}

void EscribirTexto(int x, int y, string texto, ConsoleColor color)
{
    for (int i = 0; i < texto.Length; i++) Escribir(x + i, y, texto[i], color);
}

void Dibujar()
{
    for (int y = 0; y < altoPantalla; y++)
        for (int x = 0; x < anchoPantalla; x++) { pantalla[y, x] = ' '; colores[y, x] = ConsoleColor.Gray; }

    // El laberinto, con TUS colores (cada casilla ocupa 2 columnas de la consola)
    for (int f = 0; f < filasMapa; f++)
    {
        for (int c = 0; c < columnasMapa; c++)
        {
            char ch = tablero[f, c];
            ConsoleColor color = AColor(ColorDeCasilla(ch), ConsoleColor.Black);
            if (color == ConsoleColor.Black || ch == ' ') continue;
            if (ch == '#') { Escribir(c * 2, f + 2, '█', color); Escribir(c * 2 + 1, f + 2, '█', color); }
            else Escribir(c * 2, f + 2, ch, color);
        }
    }
    for (int g = 0; g < 4; g++) Escribir(fColumna[g] * 2, fFila[g] + 2, 'M', fColor[g]);
    Escribir(jColumna * 2, jFila + 2, juegoTurno % 2 == 0 || direccionActual == "" ? 'C' : 'O', AColor(colorJugador, ConsoleColor.Yellow));

    int quedan = ContarPuntos((char[,])tablero.Clone());
    EscribirTexto(0, 0, "PUNTOS: " + juegoPuntaje + "   VIDAS: " + new string('♥', juegoVidas) + "   QUEDAN: " + (quedan >= 0 ? quedan.ToString() : "?"), ConsoleColor.White);
    EscribirTexto(0, 1, juegoPausa > 0 ? "¡Prepárate!" : "Flechas o WASD para moverte - ESC para salir", juegoPausa > 0 ? ConsoleColor.Yellow : ConsoleColor.DarkGray);

    try
    {
        for (int y = 0; y < altoPantalla; y++)
        {
            for (int x = 0; x < anchoPantalla; x++)
            {
                if (pantalla[y, x] != pantallaAntes[y, x] || colores[y, x] != coloresAntes[y, x])
                {
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = colores[y, x];
                    Console.Write(pantalla[y, x]);
                    pantallaAntes[y, x] = pantalla[y, x];
                    coloresAntes[y, x] = colores[y, x];
                }
            }
        }
    }
    catch (Exception)
    {
        // La ventana es muy chica: pedimos agrandarla y volvemos a dibujar todo
        Console.ResetColor();
        Console.Clear();
        Console.WriteLine("La ventana es muy pequeña. Hazla más grande, por favor.");
        for (int y = 0; y < altoPantalla; y++)
            for (int x = 0; x < anchoPantalla; x++) pantallaAntes[y, x] = '\0';
    }
}

bool PantallaFinal()
{
    Dibujar();
    Console.SetCursorPosition(0, altoPantalla);
    Console.ForegroundColor = juegoEstado == "gano" ? ConsoleColor.Green : ConsoleColor.Red;
    Console.WriteLine(juegoEstado == "gano" ? "¡GANASTE! Te comiste todos los puntos." : "GAME OVER. Los fantasmas te atraparon.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("ENTER = jugar otra vez   ESC = salir");
    while (Console.KeyAvailable) Console.ReadKey(true);
    while (true)
    {
        ConsoleKey k = Console.ReadKey(true).Key;
        if (k == ConsoleKey.Enter) return true;
        if (k == ConsoleKey.Escape) return false;
    }
}

void ProbarSinPantalla()
{
    ReiniciarJuegoSinConsola();
    for (int t = 0; t < 3000 && juegoEstado == "jugando"; t++)
    {
        if (t % 7 == 0) direccionDeseada = direccionesPosibles[(t / 7) % 4];
        Paso();
    }
    Console.WriteLine("estado=" + juegoEstado + " puntaje=" + juegoPuntaje + " vidas=" + juegoVidas + " quedan=" + ContarPuntos((char[,])tablero.Clone()));
}

void ReiniciarJuegoSinConsola()
{
    for (int f = 0; f < filasMapa; f++)
        for (int c = 0; c < columnasMapa; c++)
            tablero[f, c] = laberinto[f][c];
    juegoPuntaje = 0;
    juegoVidas = Math.Clamp(vidasIniciales, 1, 9);
    juegoEstado = "jugando";
    ReiniciarPosiciones();
}
