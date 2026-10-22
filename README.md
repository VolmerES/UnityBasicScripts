# Unity Basic Scripts

Scripts en C# de mis dos primeros juegos en Unity, hechos para aprender el motor antes de mi primera game
jam, la [de Madrid](https://github.com/VolmerES/GameJamMadridCarnival). Solo están los scripts, sin escenas ni assets: sirven de referencia para montar
algo parecido desde cero.

## Ball

Un juego de bola al estilo *Roll-a-Ball*: recoges todos los objetos del nivel esquivando enemigos y sin
caerte, y pasas al siguiente.

| Script | Qué hace |
|---|---|
| `JugadorFinal.cs` | Movimiento de la bola con física |
| `Collectible.cs` | Objeto recogible, que avisa al `GameManager` |
| `GameManager.cs` | Cuenta los recogidos y carga la escena siguiente cuando no queda ninguno |
| `Enemigo.cs` | Enemigo que persigue al jugador con un `NavMeshAgent`; si te toca, reinicia el nivel |
| `KillZone.cs` | Zona de muerte: si te caes del mapa, reinicia el nivel |
| `MainMenu.cs`, `WinScene.cs` | Menú principal y pantalla de victoria, que vuelve al menú a los 3 segundos |
| `MusicManager.cs` | Música de fondo que sigue sonando al cambiar de escena (singleton con `DontDestroyOnLoad`) |

## Pong

El Pong de toda la vida, para dos jugadores en el mismo teclado o contra el ordenador.

| Script | Qué hace |
|---|---|
| `Players.cs` | Palas de los jugadores: una con el eje `Vertical` y otra con `VerticalWS`, que hay que crear en el Input Manager |
| `IA.cs` | Pala rival: sigue la altura de la bola a velocidad fija |
| `Ball.cs` | Saque en diagonal aleatoria y reinicio tras cada gol |
| `Goal.cs` | Detecta los goles |
| `GameManager.cs` | Marcador, y vuelta de bola y palas al centro tras cada gol |

## Cómo usarlos

Crea un proyecto 2D (Pong) o 3D (Ball) en Unity, copia la carpeta en `Assets/` y arrastra cada script
a su objeto. Los textos de la interfaz usan **TextMeshPro**.
