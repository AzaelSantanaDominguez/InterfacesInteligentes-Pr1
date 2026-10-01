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

[Ver script de Ejercicio1](Scripts/ChanceColor.cs)

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
