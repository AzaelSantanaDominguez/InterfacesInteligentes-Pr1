# InterfacesInteligentes-Pr1

## Ejercicio 1 - Cambio de color

Se ha creado un script asociado a un objeto de la escena que permite modificar su color.

El funcionamiento es el siguiente:

- Se obtiene el color inicial del objeto.
- Se utiliza un `Color` con sus componentes **R, G y B**.
- Cada cierto número de frames se modifica aleatoriamente **una de las tres componentes** del color.
- El número de frames que deben pasar entre cada cambio se puede modificar desde el **Inspector de Unity**.
- El nuevo color se aplica al material del objeto.
- El número de frames utilizado inicialmente es de **120 frames**.

### Conceptos utilizados

- `Color`
- `Renderer`
- `GetComponent<Renderer>()`
- `Random.Range()`
- `Update()`
- Contador de frames
- Inspector de Unity

### Prueba de ejecución

<img width="1504" height="715" alt="EJ1" src="https://github.com/user-attachments/assets/d5dd9521-2fab-441e-82c9-609aa6e9c776" />

[Ver script de Ejercicio1](Scripts/ChangeColor.cs)

## Ejercicio 2 - Operaciones con vectores

### Especificaciones

Se ha creado un script asociado a una esfera que contiene dos vectores `Vector3`.

Los valores de ambos vectores se pueden modificar desde el **Inspector de Unity**.

A partir de estos vectores se calculan:

1. La **magnitud** de cada vector.
2. El **ángulo** formado entre ambos vectores.
3. La **distancia** entre los dos vectores.
4. Qué vector se encuentra a **mayor altura**, comparando su componente `Y`.

Los resultados se muestran tanto en la **consola de Unity** como en el **Inspector** mediante variables públicas.

### Conceptos utilizados

- `Vector3`
- `Vector3.magnitude`
- `Vector3.Angle()`
- `Vector3.Distance()`
- Componentes `x`, `y`, `z`
- Variables públicas en el Inspector
- `Debug.Log()`

### Prueba de ejecución

<img width="1917" height="1002" alt="EJ2" src="https://github.com/user-attachments/assets/23436b74-4b0f-41bc-94dc-1a98b4b6b60f" />

[Ver script de Ejercicio2](Scripts/ShowValues.cs)

## Ejercicio 3 - Posición de la esfera

### Especificaciones

Se ha creado un script asociado a una esfera para mostrar su posición en la escena.

La posición se obtiene mediante el componente `Transform` del objeto y se muestra en la consola de Unity. ( Tambien se puede hacer usando GetComponent<Transform> ).

La posición se representa mediante un `Vector3`, formado por las coordenadas:

- `X`
- `Y`
- `Z`

### Conceptos utilizados

- `Transform`
- `transform.position`
- `Vector3`
- `Debug.Log()`

### Prueba de ejecución

<img width="1873" height="929" alt="EJ3" src="https://github.com/user-attachments/assets/4cedd14e-b7a8-4a32-9669-c3e7cae6e757" />

[Ver script de Ejercicio3](Scripts/ShowTransform.cs)

## Ejercicio 4 - Distancia entre objetos

### Especificaciones

Se ha creado un script asociado a la esfera para calcular la distancia entre el **cubo** y el **cilindro**.

Para localizar ambos objetos se utilizan **Tags**:

- El cubo tiene el Tag `cubepepe`.
- El cilindro tiene el Tag `cylinderpepe`.

El script obtiene los objetos mediante:

```csharp
GameObject.FindWithTag()
```

Una vez encontrados, se guarda su posición inicial.

Durante la ejecución, el script comprueba si alguno de los dos objetos ha cambiado de posición. Si se detecta un movimiento, se vuelve a calcular la distancia entre ambos objetos.

El resultado se muestra en la consola de Unity.

## Conceptos utilizados
- `GameObject`
- `Tags`
- `GameObject.FindWithTag()`
- `Transform`
- `transform.position`
- `Vector3`
- `Vector3.Distance()`
- `Update()`
- `Detección de cambios de posición`
- `Debug.Log()`

### Prueba de ejecución

<img width="1911" height="950" alt="EJ4" src="https://github.com/user-attachments/assets/d2acc45b-0be2-461c-a6a3-45d2546dfea5" />

[Ver script de Ejercicio4](Scripts/CalculateDistance.cs)

## Ejercicio 5 — Desplazamiento mediante un Vector3

### Descripción

En este ejercicio se implementa el desplazamiento de un objeto utilizando un `Vector3` definido desde el Inspector de Unity.

Al iniciar la escena, se guarda la posición inicial del objeto. Cuando se pulsa la tecla asociada al eje `Jump` (por defecto, la barra espaciadora), el objeto se desplaza desde su posición inicial utilizando el desplazamiento indicado en el Inspector.

### Implementación

El script utiliza dos variables `Vector3`:

- `displacement`: desplazamiento que se puede configurar desde el Inspector.
- `initialPosition`: almacena la posición que tenía el objeto al comenzar la ejecución.

En `Start()` se guarda la posición inicial:

```csharp
initialPosition = transform.position;
```

### Prueba de ejecución

<img width="1918" height="1013" alt="EJ5" src="https://github.com/user-attachments/assets/9930853f-3243-4aef-8ed9-d12698e7efc3" />

[Ver script de Ejercicio4](Scripts/Ej5.cs)

## Ejercicio 6 - Detección de teclas y velocidad

### Especificaciones

Se ha creado un script asociado a un cubo que contiene una variable pública `velocity` para representar su velocidad.

El valor de la velocidad se puede modificar directamente desde el **Inspector de Unity**.

Durante la ejecución, el script obtiene los valores de los ejes horizontal y vertical mediante:

```csharp
Input.GetAxis("Horizontal")
Input.GetAxis("Vertical")
```

### Prueba de ejecución

<img width="1912" height="1026" alt="EJ6" src="https://github.com/user-attachments/assets/e52662d2-403d-4ff3-946d-2ef7309c6111" />

[Ver script de Ejercicio4](Scripts/Ej5.cs)

## Ejercicio 7 - Mapeo de la tecla H a la función de disparo

### Especificaciones

Se ha configurado el **Input Manager de Unity** para modificar el mapeo de la función de disparo.

Se ha cambiado la tecla asociada a la acción `Fire1`, estableciendo la tecla **H** como nuevo control.

De esta forma, al pulsar la tecla **H**, se activa la función de disparo (`Fire1`).

Este ejercicio no requiere código, ya que la configuración se realiza directamente desde el **Input Manager** de Unity.

### Conceptos utilizados

- Input Manager
- `Fire1`
- Mapeo de controles
- Configuración de teclas
- Tecla `H`

### Prueba de ejecución

<img width="1919" height="1027" alt="Ej7" src="https://github.com/user-attachments/assets/0bcde634-5c7b-4a9b-966f-3c33705b5c88" />

## Ejercicio 8 - Movimiento mediante vector de dirección

### Especificaciones

Se ha creado un script asociado a un cubo que permite controlar su movimiento mediante un vector de dirección y una velocidad.

El vector `moveDirection` se puede modificar desde el **Inspector de Unity**, al igual que la propiedad `speed`, que representa la velocidad del movimiento.

El movimiento se realiza en cada iteración mediante:

```csharp
transform.Translate(moveDirection * speed * Time.deltaTime);
```

### Conceptos utilizados

- `Vector3`
- Variables públicas en el Inspector
- `transform.Translate()`
- `Time.deltaTime`
- Vector de dirección
- Velocidad de movimiento
- Sistema de referencia local y mundial

### Resultados

#### A. Duplicas las coordenadas de la dirección del movimiento

Al duplicar las coordenadas de `moveDirection`, la dirección del movimiento se mantiene, pero aumenta la magnitud del vector.

Como resultado, el cubo se desplaza una mayor distancia en cada iteración y, por tanto, aumenta la velocidad efectiva del movimiento.

#### B. Duplicas la velocidad manteniendo la dirección del movimiento.

Al duplicar `speed` y mantener `moveDirection`, el cubo sigue desplazándose en la misma dirección, pero lo hace más rápidamente.

#### C. La velocidad que usas es menor que 1.

Al utilizar una velocidad menor que 1, el cubo continúa desplazándose en la misma dirección, pero lo hace más lentamente.

#### D. La posición del cubo tiene y>0.

Al colocar el cubo en una posición con Y > 0, el movimiento comienza desde una posición más elevada.

Si `moveDirection` no tiene componente Y, el cubo mantiene su altura mientras se desplaza.

#### E. Intercambiar movimiento relativo al sistema de referencia local y el mundial.

Si el movimiento se realiza utilizando el sistema de referencia local del objeto, el movimiento se realiza respecto a los ejes propios del cubo.

Si el movimiento se realiza utilizando el sistema de referencia mundial, el movimiento se realiza respecto a los ejes globales de la escena.

### Prueba de ejecución

<img width="1918" height="1036" alt="EJ8" src="https://github.com/user-attachments/assets/b3d539c1-cdd2-426c-ba8b-e8002fa02c5f" />

[Ver script de Ejercicio4](Scripts/Ej5.cs)

## Ejercicio 9/10 - Movimiento del cubo y la esfera mediante teclado

### Especificaciones

Se han creado dos scripts para controlar el movimiento de un cubo y una esfera mediante el teclado.

El **cubo** se mueve utilizando las teclas de dirección:

- **Flecha arriba:** movimiento vertical hacia arriba.
- **Flecha abajo:** movimiento vertical hacia abajo.
- **Flecha izquierda:** movimiento horizontal hacia la izquierda.
- **Flecha derecha:** movimiento horizontal hacia la derecha.

La **esfera** se mueve utilizando las teclas:

- **W:** movimiento vertical hacia arriba.
- **S:** movimiento vertical hacia abajo.
- **A:** movimiento horizontal hacia la izquierda.
- **D:** movimiento horizontal hacia la derecha.

Ambos objetos tienen una variable pública `speed`, que permite modificar la velocidad desde el **Inspector de Unity**.

### Conceptos utilizados

- `Input`
- `Input.GetKey()`
- `KeyCode`
- `transform.Translate()`
- `Time.deltaTime`
- `Vector3`
- Variables públicas en el Inspector
- Movimiento horizontal y vertical
- Detección de teclas

### Prueba de ejecución

<img width="1918" height="1029" alt="EJ9" src="https://github.com/user-attachments/assets/c52334c5-d85d-4b1a-91a9-75679e0b85cd" />

[Ver script de Ejercicio4](Scripts/Ej5.cs)

## Ejercicio 11 - Movimiento del cubo hacia la esfera

### Especificaciones

Se ha adaptado el movimiento del cubo para que se desplace automáticamente hacia la posición de la esfera.

La dirección del movimiento se obtiene mediante el vector que une la posición actual del cubo con la posición de la esfera.

Para evitar que la velocidad dependa de la distancia entre los dos objetos, se utiliza el método `.normalized`, que convierte el vector de dirección en un vector de magnitud 1.

Además, el cubo debe mantener su altura, por lo que el movimiento se realiza únicamente en los ejes **X** y **Z**.

La velocidad del movimiento se controla mediante la variable pública `speed`.

### Conceptos utilizados

- `Vector3`
- `Vector3.normalized`
- `transform.position`
- `transform.Translate()`
- `Time.deltaTime`
- `GameObject`
- `GameObject.FindGameObjectWithTag()`
- Tags
- Vector de dirección
- Normalización de vectores
- Movimiento hacia un objetivo
- Variables públicas en el Inspector

### Funcionamiento

En `Start()` se busca la esfera mediante su Tag:

```csharp
goal = GameObject.FindGameObjectWithTag("Meta");
```

### Prueba de ejecución

<img width="1918" height="1029" alt="EJ11" src="https://github.com/user-attachments/assets/4f0ada28-6555-43c1-87c4-80a66b9cc2b9" />

[Ver script de Ejercicio4](Scripts/Ej5.cs)

## Ejercicio 12 - Movimiento del cubo orientado hacia la esfera

### Especificaciones

Se ha adaptado el movimiento del cubo para que avance hacia la esfera mientras mantiene su orientación dirigida hacia ella.

El cubo debe girar de forma que su **eje Z positivo** apunte hacia la esfera, independientemente de su orientación inicial.

Para realizar la rotación se utiliza el método `LookAt()`, que permite orientar el objeto hacia una posición determinada.

Además, se realizan pruebas modificando la posición de la esfera mediante las teclas **W, A, S y D**.

### Conceptos utilizados

- `Transform`
- `transform.LookAt()`
- `transform.position`
- `Vector3`
- `Vector3.normalized`
- `transform.Translate()`
- `Time.deltaTime`
- `Space.World`
- `GameObject.FindGameObjectWithTag()`
- Tags
- Rotación
- Orientación hacia un objetivo
- Movimiento hacia un objetivo

### Prueba de ejecución

<img width="1918" height="1031" alt="EJ12" src="https://github.com/user-attachments/assets/c1e90762-d0e1-429c-babd-47f6b1bf6ce9" />

[Ver script de Ejercicio4](Scripts/Ej5.cs)

## Ejercicio 13 - Rotación y movimiento hacia adelante

### Especificaciones

Se ha creado un script que permite controlar la rotación y el movimiento de un objeto utilizando el eje `Horizontal`.

El eje `Horizontal` se utiliza para girar el objeto hacia la izquierda o hacia la derecha.

Una vez aplicada la rotación, el objeto avanza siempre hacia adelante siguiendo la dirección de su **eje Z positivo**.

La velocidad de movimiento y la velocidad de rotación se pueden modificar desde el **Inspector de Unity** mediante las variables `speed` y `rotationSpeed`.

### Conceptos utilizados

- `Input`
- `Input.GetAxis()`
- Eje `Horizontal`
- `Transform`
- `transform.Rotate()`
- `transform.forward`
- `transform.Translate()`
- `Time.deltaTime`
- Vector de dirección
- Eje Z positivo
- Rotación
- Movimiento hacia adelante
- `Debug.DrawRay()`

### Prueba de ejecución

<img width="1918" height="1028" alt="EJ13" src="https://github.com/user-attachments/assets/4dcfce40-aa42-4905-a903-48850d1ed9cf" />

[Ver script de Ejercicio4](Scripts/Ej5.cs)




