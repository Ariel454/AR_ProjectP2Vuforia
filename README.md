# TrashBuster
Introducción
¡Bienvenido a TrashBuster!

Este proyecto, desarrollado por Ariel454, te sumerge en una experiencia única donde tu objetivo es eliminar la basura y combatir enemigos. Utiliza la realidad aumentada para dar vida a un mundo lleno de desafíos y diversión.

## Requisitos
Unity: Versión 2022.3.10 o posterior.
## Créditos
Desarrollado por Ariel454.

## Licencia
Este proyecto no tiene licencia especificada. ¡Úsalo y disfrútalo libremente!

# Features
## AR_CAMERA
Para integrar la cámara de realidad aumentada (AR), sigue estos pasos:

Inserta la AR_Camera y configúrala con la licencia generada desde Vuforia Engine.
Agrega un ImageTarget y asigna una imagen para desplegar Vuforia.
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/1e2891fa-feb0-48e0-90bf-6ed38a5c7fd1)
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/e382c26e-225a-4529-bee6-c809bbbebfa7)


## SPAWN
Coloca los prefabs iniciales como hijos directos del ImageTarget.
Añade eventos para controlar la aparición de objetos en realidad aumentada.
Utiliza un GameObject para gestionar la aparición de objetos y asigna el script Enemy Spawner.
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/e447db5a-6fe1-4147-a3e4-be309928c29f)
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/4ecf8129-44d2-4f68-b90d-93721b1a58bd)


## ENEMY SPAWNER
Este script contiene métodos y variables esenciales para el spawneo de enemigos y objetos de basura.

Campos Públicos: enemigoPrefab, botellaPrefab, bloquePrefab, pilaPrefab
Métodos: InstanciarEnemigos, InstanciarBasura, InstanciarBasuraTipo
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/da8055a2-95e5-446c-9728-ce14b6472448)

## PERSONAJE PRINCIPAL
NAVE SCRIPT
Este script controla la nave del jugador.

Campos Públicos: capacidadText, mensajeGanador, basuraTexto, BasuraRestante, textoGameOverParent, TextoGameOver, capacidadMaxima, vidaTotal, barraVida, basuraRecogida, capacidadActual, totalBasura
Métodos: Start, OnTriggerEnter, ActualizarTextoCapacidad, RecibirDanio, MostrarTextoGameOver, MostrarTextoWin
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/d2477fe9-e5b5-4e84-a24a-ad0de48ecfda)
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/41b33278-9a3c-4d55-9c40-d47cc948df9e)

## CONTROLADOR NAVE JOYSTICK
Controla el movimiento de la nave usando un joystick.

Campos Públicos: velocidad, velocidadRotacion, joystick, joystickRotacion
Método: Update
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/9b9b211f-bb2b-4f6a-a729-1775535f638a)
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/e3005cbb-1dfe-409a-a33f-40ddd7edec22)
## CAÑON NAVE
Maneja la lógica del cañón de la nave.
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/1352bc5b-5b70-4fd4-9471-3f2150e75edb)


Campos Públicos: cañon, bolitaPrefab, velocidadDisparo, botonDisparar
Método: Disparar
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/5ccd5de5-273b-4dd8-a31b-b39c8a47ec8b)
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/6d4fbe48-6cfa-4798-99d1-e33b55f8e9f0)

## BALL DESTROY
Script asociado a las balas para su destrucción.
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/772d3fa9-83d7-45c5-bcbc-1fe798555af7)

Método: OnTriggerEnter
## ENEMIGO CONTROLLER
Controla el comportamiento de los enemigos.
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/b35a6eb7-7720-45bb-81b2-093e714c7090)

Campos Públicos: velocidad
Métodos: Start, IniciarPersecucion, Update, ConfigurarJugador
## MENÚS Y ESCENAS
## MAIN MENU
Maneja las transiciones entre menús y escenas.
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/0cf23a0b-3b4b-42f6-8d2e-0ae80d8c30d3)

Método: LoadScene
## CHANGE SCENES
Controla el cambio de escenas en el juego.

Método: LoadScene
## GAME MANAGER
Gestiona la lógica del juego, incluyendo la pausa y la cantidad de enemigos permitidos.
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/ff123af0-2c59-4c08-9f87-68374a130778)

![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/e30b0ab6-0865-41fd-a9a7-317dfdc22cd1)

Campos Públicos: isPaused, pauseMenu, cantidadEnemigosPermitidos, limiteBasuraPorTipoPermitido, juegoReiniciado
Métodos: Awake, Update, TogglePause, ResumeGame, LoadScene, ReiniciarJuego
## BARRA DE VIDA
La barra de vida se compone de dos imágenes en el canvas, una para el fondo y otra para la barra de vida.
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/81d7ef38-2d2f-4c8f-9f14-1426c99a9b63)
![image](https://github.com/Ariel454/AR_ProjectP2Vuforia/assets/121766763/0181f3b7-af95-465f-a52a-ab9c77397657)

