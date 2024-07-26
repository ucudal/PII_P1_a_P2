# Objetivo

Recordar estructuras de control de flujo y estructuras de repetición condicional en algoritmos expresados en lenguaje natural y su correspondiente implementación en Python; a partir del algoritmo en lenguaje natural y en Python, ver cómo se implementan esos algoritmos en C#.

> [!IMPORTANT]
> En este repositorio los algoritmos en C# están implementados como métodos estáticos en la clase `Program` por simplicidad; no recomendamos que hagas tus programas de esta forma, verás más adelante en el curso la forma correcta de hacerlo.

Este repositorio contiene ejemplos de código en Python y en C#.

Cuando abras los archivos `.py` de Python, Rider te sugerirá instalar el complemento [Python Community Edition](https://plugins.jetbrains.com/plugin/7322-python-community-edition), pero no te preocupes de hacerlo ahora; sigue las instrucciones cuando Rider te lo pregunte.

> [!NOTE]
> En el código Python los algoritmos están implementados en una función definida al comienzo del programa; esa función se usa con algunos ejemplos para mostrar su funcionamiento en el programa principal. En el código en C# los algoritmos están implementados en un método estático al comienzo de la clase `Program`; ese método se usa con algunos ejemplos en el método `Main` de la clase `Program`.
> 
> Para ejecutar el código Python, haz clic con el botón secundario del mouse en el fondo del editor y elige la opción ![](https://intellij-icons.jetbrains.design/icons/AllIcons/expui/run/run_dark.svg) `Run`. Para ejecutar el código C#, haz clic en el ícono ![](https://intellij-icons.jetbrains.design/icons/AllIcons/expui/run/run_dark.svg) que aparece junto al método `Main` de la clase `Program.`

# Ejercicio 1

## Algoritmo en lenguaje natural

Escribir una función que implemente el valor absoluto, pero sin usar la función provista por el lenguaje. Para los números positivos su valor absoluto es igual al número, mientras que para los negativos su valor absoluto es el número multiplicado por -1.

A continuación algunos ejemplos:
```python
valor_absoluto(52)  # Devuelve 52
valor_absoluto(-52)  # Devuelve también 52
```

## Código en Python

Es necesario determinar si el número es menor que cero o no; eso se hace con la estructura de control `if-else`: dado un número `n`, la sentencia `if n < 0:` nos permite determinar si el número es menor que cero y ejecutar ciertas instrucciones en ese caso; en caso contrario, es decir, si el número es mayor o igual que cero, la sentencia `else:` nos permite ejecutar otras instrucciones.

```python
def valor_absoluto(n):
    if n < 0:
        return -1*n
    else:
        return n


print("Valor absoluto de -52:", valor_absoluto(-52))
print("Valor absoluto de 52:", valor_absoluto(52))
```

Puedes ver y ejecutar el programa [aquí](./Ejercicio_1/Ejercicio_1.py).

## Código en C#

El algoritmo en C# se implementa también con la estructura de control `if-else`.

> [!IMPORTANT]
> Aunque la forma como escribes un `if` o un `if-else` en Python y en C# sea diferente, si sabes determinar la estructura de control correcta en Python a partir del texto en lenguaje natural, basta con que sepas cómo escribir esa estructura en C#, porque la estructura de control en sí debería ser la misma.

Un posible equivalente a la función `def valor_absoluto(n)` de Python es el método `static int ValorAbsoluto(int n)` en C#.

```csharp
static class Program
{
    static int ValorAbsoluto(int n)
    {
        if (n < 0)
        {
            return n * -1;
        }
        else
        {
            return n;
        }
    }

    static void Main()
    {
        Console.WriteLine("C#");
        Console.WriteLine("Valor absoluto de -52: " + ValorAbsoluto(-52).ToString());
        Console.WriteLine("Valor absoluto de 52:" + ValorAbsoluto(52).ToString());
    }
}
```

Puedes ver y ejecutar el programa [aquí](./Ejercicio_1/Ejercicio_1.cs):

Varias diferencias entre ambos lenguajes, estas son algunas:

<table>
  <tr style="vertical-align: top">
    <td style="width: 50%">
      Python
    </td>
    <td style="width: 50%">
      C#
    </td>
  </tr>
  <tr style="vertical-align: top">
    <td>
      Los bloques de código se definen con sangría
    </td>
    <td>
      Los bloques de código se definen con `{` y `}`
    </td>
  </tr>
  <tr>
    <td>
        Es posible definir funciones "libres", es decir, en cualquier lugar del código
    </td>
    <td>
      El código va siempre dentro de métodos, nunca "libre"
    </td>
  </tr>
  <tr>
    <td>
      Las sentencias terminan cuando se termina una línea
    </td>
    <td>
      Las sentencias terminan con `;`
    </td>
  </tr>
  <tr style="vertical-align: top">
    <td>
      No se declara el tipo de los parámetros
    </td>
    <td>
      Es necesario declarar siempre el tipo de los parámetros; en este caso el tipo es  que corresponde a enteros
    </td>
  </tr>
  <tr style="vertical-align: top">
    <td>
      No se declara el resultado, sino que se asume a partir de la sentencia <code>return</code>
    </td>
    <td>
      Es necesario declarar el tipo del resultado; en este caso el tipo del resultado también es <code>int</code>  
    </td>
  </tr>
  <tr style="vertical-align: top">
    <td>
      El nombre usa <b>snake_case</b>; las palabras se escriben con minúsculas, separadas por `_`
    </td>
    <td>
      El nombre usa <b>PascalCase</b>; las palabras se escriben con la inicial en mayúsculas, sin separación
    </td>
  </tr>
  <tr>
    <td>
      Los paréntesis son opcionales en la condición del `if`
    </td>
    <td>
      La condición del `if` va siempre entre paréntesis
    </td>
  </tr>
  <tr style="vertical-align: top">
    <td>
      Para imprimir en la terminal se usa <code>print()</code>, que es una función
    </td>
    <td>
      Para imprimir en la terminal se usa el método <code>WriteLine()</code> de la clase <code>Console</code>
    </td>
  </tr>
  <tr style="vertical-align: top">
    <td>
      <code>print</code> recibe varios datos a imprimir, convierte los que sea necesario en cadenas de caracteres, los concatena y los muestra en la terminal
    </td>
    <td>
      <code>Console.WriteLine</code> recibe un parámetro que es una cadena de caracteres y la muestra en la terminal; el programador convierte los datos que sea necesario a cadenas de caracteres y los concatena antes de pasarlos a la función
    </td>
  </tr>
</table>

Aquí ya puedes ver algunas diferencias en la filosofía subyacente en ambos lenguajes. Mientras en Python el lenguaje asume tipos de datos, hace conversiones automáticas, etc. en C# el programador debe anunciar su intención y realizar él las conversiones necesarias. Esto no es un regla a raja tabla, hay excepciones, pero en términos generales se cumple esto. Las diferencias no son ni buenas ni malas, ambos son lenguajes muy utilizados y tienen su comunidad de seguidores. Ya te vas a acostumbrar.

# Ejercicio 2

## Algoritmo en lenguaje natural

Un programa lee el candidato por el cual el usuario va a votar. Las posibilidades son: candidato `A` por el partido rojo, candidato `B` por el partido verde, candidato `C` por el partido azul. Según el candidato elegido —`A`, `B` ó `C`, en forma de string— se imprimirá el mensaje "Usted ha votado por el partido [color que corresponda al candidato elegido]". Si el usuario ingresa una opció́n que no corresponde a ninguno de los candidatos disponibles, imprimir "Opción errónea".

## Código en Python

Es necesario determinar si el usuario escribió `A`, `B` o `C`; eso se hace con la estructura de control `if-elif-else`, que es similar a la estructura `if-else` del ejercicio anterior, pero soporta más condiciones.

```python
def votar(candidato):
    if candidato == 'A':
        return "Usted a votado por el partido Rojo"
    elif candidato == 'B':
        return "Usted a votado por el partido Verde"
    elif candidato == 'C':
        return "Usted a votado por el partido Azul"
    else:
        return "Opción errónea"


print("A - Partido Rojo")
print("B - Partido Verde")
print("C - Partido Azul")
print()

opc = input("Ingrese opción: ")
opc = opc.upper()

print(votar(opc))
```

Puedes ver y ejecutar el programa [aquí](./Ejercicio_2/Ejercicio_2.py).

## Código en C#

Como dijimos antes, la estructura de control `if-elif-else` de Python permite ejecutar código evaluando varias condiciones. C# no tiene una estructura `if-elif-else`, pero es posible evaluar varias condiciones con varias estructuras de control `if-else` concatenadas, una especie de `if-else-if-else`; vas a ver que el código queda muy similar.

```csharp
static class Program
{
    static string Votar(string candidato)
    {
        if (candidato == "A")
        {
            return "Usted a votado por el partido Rojo";
        }
        else if (candidato == "B")
        {
            return "Usted a votado por el partido Verde";
        }
        else if (candidato == "C")
        {
            return "Usted a votado por el partido Azul";
        }
        else
        {
            return "Opción errónea";
        }
    }

    static void Main()
    {
        Console.WriteLine("C#");
        Console.WriteLine("A - Partido Rojo");
        Console.WriteLine("B - Partido Verde");
        Console.WriteLine("C - Partido Azul");
        Console.WriteLine();

        Console.Write("Ingrese opción: ");
        string opc = Console.ReadLine();
        opc = opc.ToUpper();

        Console.WriteLine(Votar(opc));
    }
}
```

Puedes ver que la secuencia de estructuras de control condicional `if-else` concatenadas en el ejemplo en C# quedan similares a las de Python.

Algunas otras diferencias:

<table>
  <tr style="vertical-align: top">
    <td style="width: 50%">
      Python
    </td>
    <td style="width: 50%">
      C#
    </td>
  </tr>
  <tr style="vertical-align: top">
    <td>
      `input()` muestra un mensaje al usuario y lee lo que usuario escriba
    </td>
    <td>
      El método `WriteLine()` de la clase `Console` muestra un mensaje y el método `ReadLine()` de esa clase lee lo que el usuario escribe
    </td>
  </tr>
  <tr>
    <td>
      Para obtener la string `opc` en mayúsculas se usa el método `upper()`
    </td>
    <td>
      El método `ToUpper()` retorna la string `opc` convertida en mayúsculas
    </td>
  </tr>
</table>

Así como en Python existe la estructura de control condicional `if-elif-else` que no existe en C#, en C# existe una estructura de control condicional `switch` que ejecuta un conjunto de instrucciones dependiendo de una condición. Puedes ver a continuación el mismo método `Votar()` implementado con `switch` en lugar de con `if-else`:

```csharp
static string Votar(string candidato)
{
    switch (candidato)
    {
        case "A":
        {
            return "Usted a votado por el partido Rojo";
        }
        case "B":
        {
            return "Usted a votado por el partido Verde";
        }
        case "C":
        {
            return "Usted a votado por el partido Azul";
        }
        default:
        {
            return "Opción errónea";
        }
    }
}
```
