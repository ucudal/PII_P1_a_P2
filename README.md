<img alt="UCU" src="https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg"
width="150"/>

# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

# Pasando de Programación I a Programación II

## Objetivo

Recordar estructuras condicionales y estructuras de repetición condicional en
algoritmos expresados en lenguaje natural y su correspondiente implementación en
Python; a partir del algoritmo en lenguaje natural y en Python, ver cómo se
implementan esos algoritmos en C#.

No tienes que programar nada, los algoritmos ya están implementados tanto en
Python como en C#. Pero sí tienes que comenzar a familiarizarte con código en C#
y entender las diferencias entre ambos lenguajes.

> [!IMPORTANT]
> Para ejecutar el código de estos ejemplos clona este repositorio en tu equipo
> primero y ábrelo en Rider luego para ejecutar el código. Vas a ver en la
> esquina superior derecha de Rider una lista desplegable con los nombres de los
> ejemplos y al lado el icono
> ![](https://intellij-icons.jetbrains.design/icons/AllIcons/expui/run/run_dark.svg);
> haz clic en este ícono para ejecutar el ejemplo.

Cuando abras los archivos `.py` de Python, Rider te sugerirá instalar el
complemento [Python Community
Edition](https://plugins.jetbrains.com/plugin/7322-python-community-edition),
pero no te preocupes de hacerlo ahora; sigue las instrucciones cuando Rider te
lo pregunte.

> [!NOTE]
> En el código Python los algoritmos están implementados en una función
> definida al comienzo del programa; esa función se usa con algunos ejemplos
> para mostrar su funcionamiento en el programa principal que está luego de la
> función. En el código en C# los algoritmos están implementados en métodos
> estáticos de una clase `Functions`; no es la única forma en que se podría
> haber hecho, y no es la forma que recomendamos que uses para tus programas,
> pero debería ser fácil darse cuenta de la equivalencia.

# Ejercicio 1

## Algoritmo en lenguaje natural

Escribir una función que implemente el valor absoluto, pero sin usar la función
provista por el lenguaje. Para los números positivos su valor absoluto es igual
al número, mientras que para los negativos su valor absoluto es el número
multiplicado por -1.

A continuación algunos ejemplos:

```python
absolute_value(52)  # Devuelve 52
absolute_value(-52)  # Devuelve también 52
```

## Código en Python

Es necesario determinar si el número es menor que cero o no; eso se hace con la
estructura de control `if-else`: dado un número `n`, la sentencia `if n < 0:`
nos permite determinar si el número es menor que cero y ejecutar ciertas
instrucciones en ese caso; en caso contrario, es decir, si el número es mayor o
igual que cero, la sentencia `else:` nos permite ejecutar otras instrucciones.

```python
def absolute_value(number):
    if number < 0:
        return number * -1
    else:
        return number


print("Pyton")
print("Valor absoluto de -52:", absolute_value(-52))
print("Valor absoluto de 52:", absolute_value(52))
```

Puedes ver y ejecutar el programa [aquí](./Ejercicio_1/Ejercicio_1.py).

## Código en C#

El algoritmo en C# se implementa también con la estructura de control `if-else`.

> [!IMPORTANT]
> Aunque la forma como escribes un `if` o un `if-else` en Python y en C# sea
> diferente, si sabes determinar la estructura de control correcta en Python a
> partir del texto en lenguaje natural, basta con que sepas cómo escribir esa
> estructura en C#, porque la estructura de control en sí debería ser la misma.

Un posible equivalente a la función `def valor_absoluto(n)` de Python es el
método `int ValorAbsoluto(int)` en C#.

```csharp
Console.WriteLine("C#");
Console.WriteLine("Valor absoluto de -52: " + Functions.AbsoluteValue(-52).ToString());
Console.WriteLine("Valor absoluto de 52:" + Functions.AbsoluteValue(52).ToString());

public static class Functions
{
    public static int AbsoluteValue(int number)
    {
        if (number < 0)
        {
            return number * -1;
        }
        else
        {
            return number;
        }
    }
}
```

> [!NOTE] Los programas en C# usan lo que se llama *top level statements*.
> Aunque parece que el código "flota" en el archi, de forma transparante para el
>programador el compilador convierte estos *top level statement* en la
> implementación de un método `Main` de la clase `Program`. Todo el código que
> escribes en C#, a diferencia de Python, es siempre dentro de un método de una
> clase.

Puedes ver y ejecutar el programa [aquí](./Ejercicio_1/Ejercicio_1.cs):

Varias diferencias entre ambos lenguajes, estas son algunas:

<table>
  <tr>
    <th width="50%">
      Python
    </th>
    <th width="50%">
      C#
    </th>
  </tr>
  <tr>
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
  <tr>
    <td>
      No se declara el tipo de los parámetros
    </td>
    <td>
      Es necesario declarar siempre el tipo de los parámetros; en este caso el tipo es <code>int</code> que corresponde a enteros
    </td>
  </tr>
  <tr>
    <td>
      No se declara el resultado, sino que se asume a partir de la sentencia <code>return</code>
    </td>
    <td>
      Es necesario declarar el tipo del resultado; en este caso el tipo del resultado también es <code>int</code>
    </td>
  </tr>
  <tr>
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
  <tr>
    <td>
      Para imprimir en la terminal se usa <code>print()</code>, que es una función
    </td>
    <td>
      Para imprimir en la terminal se usa el método <code>WriteLine()</code> de la clase <code>Console</code>
    </td>
  </tr>
  <tr>
    <td>
      <code>print</code> recibe varios datos a imprimir, convierte los que sea necesario en cadenas de caracteres, los concatena y los muestra en la terminal
    </td>
    <td>
      <code>Console.WriteLine</code> recibe un parámetro que es una cadena de caracteres y la muestra en la terminal; el programador convierte los datos que sea necesario a cadenas de caracteres y los concatena antes de pasarlos a la función
    </td>
  </tr>
</table>

Aquí ya puedes ver algunas diferencias en la filosofía subyacente en ambos
lenguajes. Mientras en Python el lenguaje asume tipos de datos, hace
conversiones automáticas, etc. en C# el programador debe anunciar su intención y
realizar él las conversiones necesarias. Esto no es un regla a raja tabla, hay
excepciones, pero en términos generales se cumple esto. Las diferencias no son
ni buenas ni malas, ambos son lenguajes muy utilizados y tienen su comunidad de
seguidores. Ya te vas a acostumbrar.

> [!NOTE]
> El nombre de la variable `n` está en minúsculas; los elementos que no son
> visibles desde fuera de donde se declaran, no usan **PascalCase** sino
> **camelCase**; este último se diferencia por tener la primera letra en
> minúsculas, luego es igual al primero.

# Ejercicio 2

## Algoritmo en lenguaje natural

Un programa lee el candidato por el cual el usuario va a votar. Las
posibilidades son: candidato `A` por el partido rojo, candidato `B` por el
partido verde, candidato `C` por el partido azul. Según el candidato elegido
—`A`, `B` ó `C`, en forma de string— se imprimirá el mensaje "Usted ha votado
por el partido [color que corresponda al candidato elegido]". Si el usuario
ingresa una opción que no corresponde a ninguno de los candidatos disponibles,
imprimir "Opción errónea".

## Código en Python

Es necesario determinar si el usuario escribió `A`, `B` o `C`; eso se hace con
la estructura de control `if-elif-else`, que es similar a la estructura
`if-else` del ejercicio anterior, pero soporta más condiciones.

```python
def vote(candidate):
    if candidate == 'A':
        return "Usted a votado por el partido Rojo"
    elif candidate == 'B':
        return "Usted a votado por el partido Verde"
    elif candidate == 'C':
        return "Usted a votado por el partido Azul"
    else:
        return "Opción errónea"

print("Python")
print("A - Partido Rojo")
print("B - Partido Verde")
print("C - Partido Azul")
print()

option = input("Ingrese opción: ")
option = option.upper()

print(vote(option))
```

Puedes ver y ejecutar el programa [aquí](./Ejercicio_2/Ejercicio_2.py).

## Código en C #

Como dijimos antes, la estructura de control `if-elif-else` de Python permite
ejecutar código evaluando varias condiciones. C# no tiene una estructura
`if-elif-else`, pero es posible evaluar varias condiciones con varias
estructuras de control `if-else` concatenadas, una especie de `if-else-if-else`;
vas a ver que el código queda muy similar.

```csharp
Console.WriteLine("C#");
Console.WriteLine("A - Partido Rojo");
Console.WriteLine("B - Partido Verde");
Console.WriteLine("C - Partido Azul");
Console.WriteLine();

Console.Write("Ingrese opción: ");
string option = Console.ReadLine();
option = option.ToUpper();

Console.WriteLine(Functions.Vote(option));
Console.WriteLine(Functions.VoteUsingSwitch(option));

public static class Functions
{
    public static string Vote(string candidate)
    {
        if (candidate == "A")
        {
            return "Usted a votado por el partido Rojo";
        }
        else if (candidate == "B")
        {
            return "Usted a votado por el partido Verde";
        }
        else if (candidate == "C")
        {
            return "Usted a votado por el partido Azul";
        }
        else
        {
            return "Opción errónea";
        }
    }
}

```

Puedes ver y ejecutar el programa [aquí](./Ejercicio_2/Ejercicio_2.cs)

Puedes ver que la secuencia de estructuras de control condicional `if-else`
concatenadas en el ejemplo en C# quedan similares a las de Python.

Algunas otras diferencias:

<table>
  <tr style="vertical-align: top">
    <th width="50%">
      Python
    </th>
    <th width="50%">
      C#
    </th>
  </tr>
  <tr style="vertical-align: top">
    <td>
      `input()` muestra un mensaje al usuario y lee lo que usuario escriba
    </td>
    <td>
      El método `Write()` de la clase `Console` muestra un mensaje y el método `ReadLine()` de esa clase lee lo que el usuario escribe
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

Para mostrar texto al usuario hemos usado tanto `Console.Write()` como
`Console.WriteLine()`; la diferencia es que mientras la primera deja el curso
inmediatamente luego del texto que se escribe, la segunda pasa el cursor a la
siguiente línea.

Así como en Python existe la estructura de control condicional `if-elif-else`
que no existe en C#, en C# existe una estructura de control condicional `switch`
que ejecuta un conjunto de instrucciones dependiendo de una condición. Puedes
ver a continuación el mismo método `string Vote(string)` implementado con
`switch` en lugar de con `if-else`:

```csharp
  public static string Vote(string candidate)
  {
      switch (candidate)
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

Esta versión del método `string Vote(string)` está comentada
[aquí](./Ejercicio_2/Ejercicio_2.cs); comenta la otra versión y quita los
comentarios a esta version con `do-while` para ejecutarla.

> [!TIP] Puedes comentar o quitar los comentarios rápidamente bloques de código
> con las teclas <kbd>Ctrl</kbd>+<kbd>/</kbd> en Windows o
> <kbd>Cmd</kbd>+<kbd>/</kbd> en Mac y Linux.

# Ejercicio 3

## Algoritmo en lenguaje natural

Escribir un programa que lea el día de la semana en letras —por ejemplo,
"lunes"— e imprima el siguiente mensaje:

- Si es lunes imprima "Hoy comienza la semana. ¡Animo!",
- Si es viernes "¡Ya casi termina!"
- Si es sábado o domingo “¡Siiii! ¡Fin de semana!”
- Si el día ingresado no es ninguno de esos (pero es válido), imprimir el
  siguiente mensaje "¡Vamos que se puede!"
- Si el día ingresado no es válido entonces debe mostrar un mensaje que lo
  indique

## Código en Python

Es necesario determinar cuál es el día de la semana; eso se hace con la
estructura de control `if-elif-else` evaluando múltiples condiciones, aunque en
algún caso será necesario combinar las condiciones, por ejemplo para "sábado o
domingo".

```python
def message_for_day(week_day):
    if week_day.lower() == "lunes":
        return "Hoy comienza la semana. ¡Ánimo!"
    elif week_day.lower() == "viernes":
        return "Ya casi termina!"
    elif week_day.lower() == "sábado" or \
            week_day.lower() == "domingo":
        return "¡Siiii! ¡Fin de semana!"
    elif (week_day.lower() == "martes" or
          week_day.lower() == "miércoles" or
          week_day.lower() == "jueves"):
        return "¡Vamos que se puede!"
    else:
        return "¡Dia de la semana invalido!"


print("Python")
input_day = input("Ingrese el día de la semana: ")
print(message_for_day(input_day))
```

Puedes ver y ejecutar el programa [aquí](./Ejercicio_3/Ejercicio_3.py)

Vean el uso de `or` para evaluar si el día de la semana es "sábado o domingo"
por ejemplo. Podría haber un `elif` con la condición `dia_semana.lower() ==
sábado` para evaluar si el día es sábado y otro con la condición
`dia_semana.lower() == domingo` para evaluar si es domingo, pero como en ambos
casos hay que mostrar el mismo mensaje, entonces es mejor usar `or` para evaluar
si es sábado o si es domingo.

## Código en C#

Nuevamente, la estructura de control a usar en C# es una concatenación de
estructuras de control `if-else` como en el ejemplo anterior. El método estático
`string MensajeFroDay(string)` de la clase `Functions` sería el equivalente a la
función `message_for_day()` en Python.

```csharp
Console.WriteLine("C#");
Console.Write("Ingrese el día de la semana: ");
string inputDay = Console.ReadLine();
Console.WriteLine(Functions.MessageForDay(inputDay));

public static class Functions
{
    public static string MessageForDay(string weekDay)
    {
        if (weekDay.ToLower() == "lunes")
        {
            return "Hoy comienza la semana. !Ánimo!";
        }
        else if (weekDay.ToLower() == "viernes")
        {
            return "¡Ya casi termina!";
        }
        else if (weekDay.ToLower() == "sábado"
                 || weekDay.ToLower() == "domingo")
        {
            return "¡Siiii! ¡Fin de semana!";
        }
        else if (weekDay.ToLower() == "martes"
                 || weekDay.ToLower() == "miércoles"
                 || weekDay.ToLower() == "jueves")

        {
            return "¡Vamos que se puede!";
        }
        else
        {
            return "¡Dia de la semana invalido!";
        }
    }
}

```

Puedes ver y ejecutar el programa [aquí](./Ejercicio_3/Ejercicio_3.cs)

Algunas nuevas diferencias:

<table>
  <tr style="vertical-align: top">
    <th width="50%">
      Python
    </th>
    <th width="50%">
      C#
    </th>
  </tr>
  <tr style="vertical-align: top">
    <td>
      El operador <code>or</code> determina si cualquiera de dos expresiones lógicas —o ambas— son verdaderas
    </td>
    <td>
      El operador <code>||</code> es usado para evaluar si cualquiera de dos expresiones lógicas —o ambas— son verdaderas
    </td>
  </tr>
  <tr>
    <td>
      Cada sentencia ocupa una línea a menos que se use la continuación de línea implícita —cuando hay paréntesis por ejemplo—, como es el caso de la comparación por martes, miércoles o jueves; o que la línea termine con `\`, como es el caso de la comparación por sábado o domingo.
    </td>
    <td style="vertical-align: top">
      Es posible dividir la sentencias en múltiples líneas
    </td>
  </tr>
  <tr>
    <td>
      No es necesario indicar que la función no retorna un valor —en este caso decimos que es un procedimiento—
    </td>
    <td>
      Para indicar que un método no retorna un valor es necesario indicarlo con `void`
    </td>
  </tr>
</table>

Los otros operadores lógicos son:

| Python | C#           |
|--------|--------------|
| or     | \| o \|\|[^1]|
| and    | & o &&[^1]   |
| not    | !            |

Dicho sea de paso, vieron que para comparar si dos elementos son iguales, tanto
Python como C# usan el operador `==`; los operadores de comparación son iguales
en ambos lenguajes, esto aplica para `<`, `<=`,`>`, `>=`, `==`, `!=`.

También son iguales los operadores aritméticos `+`, `-`, `*`, `/`, `+=`, `-=`,
`*=`, `/=`[^2].

[^1]: La diferencia es si se evalúa el segundo operando. Ver
    [and](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators#logical-and-operator-)
    y
    [or](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators#conditional-logical-and-operator-).
[^2]: Mientras `/=` aplicado a objetos de tipo `int` en Python da como resultado
    un objeto de tipo `float`, en C# da un objeto de tipo `int` siempre. Ver
    [division
    operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/division-operator).

# Ejercicio 4

## Algoritmo en lenguaje natural

Escribir un programa que lea números desde el teclado, hasta que el usuario
ingrese el 0. Finalmente, mostrar la sumatoria de todos los números positivos
ingresados —solo de los números que sean positivos—.

## Código en Python

Es necesario leer un número y luego continuar leyendo repetidamente mientras el
usuario no ingrese el número cero. Esto se logra con la estructura repetitiva
condicional `while`. Para obtener la sumatoria de todos los números usamos un
acumulador.

```python
total = 0
number = int(input("Ingrese número (0 para terminar): "))
while number != 0:
    if number > 0:
        total = total + number
    number = int(input("Ingrese número (0 para terminar): "))
print("La total es: ", total)
```

Puedes ver y ejecutar el programa [aquí](./Ejercicio_4/Ejercicio_4.py)

## Código en C#

El algoritmo en C# se implementa también con la estructura repetitiva
condicional `while`.>

> [!IMPORTANT]
> Aunque la forma como escribes un `while` en Python y en C# sea diferente, si
> sabes determinar la estructura repetitiva condicional en Python a partir del
> texto en lenguaje natural, basta con que sepas cómo escribir esa estructura en
> C#, porque la estructura repetitiva condicional en sí debería ser la misma.

```csharp
Console.WriteLine("C#");
Functions.Sum();

public static class Functions
{
    public static void Sum()
    {
        int total = 0;
        Console.Write("Ingrese número (0 para terminar): ");
        int number = int.Parse(Console.ReadLine());
        while (number != 0)
        {
            if (number > 0)
            {
                total = total + number;
            }

            Console.Write("Ingrese número (0 para terminar): ");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("La suma es: " + total.ToString());
    }
}

```

Puedes ver y ejecutar el código [aquí](./Ejercicio_4/Ejercicio_4.cs).

La estructura `while` es prácticamente igual en ambos lenguajes; algunas
diferencias a continuación:

|Python|C#|
|-|-|
|Los paréntesis son opcionales en la condición del `while`|La condición del `while` va siempre entre paréntesis|
|`int()` se utiliza para convertir una string en un entero|`int.Parse()` convierte una string en un entero|

C# tiene otra estructura repetitiva condicional similar a `while` pero que
controla la condición **luego** de ejecutar el bloque de código asociado: la
estructura `do-while`. En este caso puede ser mejor usar `do-while` porque el
código para mostrar las instrucciones al usuario y leer su respuesta aparece
sólo una vez —mostramos sólo el método `Main`—.

```csharp
  public static void Sum()
  {
      int total = 0;
      int number;
      do
      {
          Console.Write("Ingrese número (0 para terminar): ");
          number = int.Parse(Console.ReadLine());
          if (number > 0)
          {
              total = total + number;
          }
      } while (number != 0);


      Console.WriteLine("La suma es: " + total.ToString());
  }
```

Esta versión del método `Main` está comentada
[aquí](./Ejercicio_4/Ejercicio_4.cs); comenta la versión con `while` y quita los
comentarios a esta version con `do-while` para ejecutarla.

# Ejercicio 5

## Algoritmo en lenguaje natural

Escribir una función que simule 20 tiradas de dos dados simultáneamente,
imprimiendo el promedio de la suma de los resultados de los dos dados. Escribir
una función que cuente la cantidad de veces que salió la cara 1, 2, ... 6 en 30
tiradas y las imprima.

## Código en Python

En ambas funciones el algoritmo se implementa con una estructura repetitiva
condicional `while` cuya condición de control es un acumulador que se incrementa
dentro del bucle.

```python
import random


def roll_dice():
    return random.randint(1, 6)


def average_20():
    i = 0
    total = 0
    while i < 20:
        dice1 = roll_dice()
        dice2 = roll_dice()
        total += dice1 + dice2
        i = i + 1
    print("Promedio total:", total / 20)
    print()


def simulate_30():
    i = 0
    face1, face2, face3, face4, face5, face6 = 0, 0, 0, 0, 0, 0
    while i < 30:
        dice = roll_dice()
        if dice == 1:
            face1 += 1
        elif dice == 2:
            face2 += 1
        elif dice == 3:
            face3 += 1
        elif dice == 4:
            face4 += 1
        elif dice == 5:
            face5 += 1
        elif dice == 6:
            face6 += 1
        i += 1
    print("cara 1:", face1)
    print("cara 2:", face2)
    print("cara 3:", face3)
    print("cara 4:", face4)
    print("cara 5:", face5)
    print("cara 6:", face6)
    print()


print("Python")
average_20()
simulate_30()
```

Puedes ver y ejecutar el código [aquí](./Ejercicio5/Ejercicio_5.py).

## Código en C#

En C# cada función se implementa en un método estático de la clase `Functions`
como hemos hecho antes. También se utiliza la estructura repetitiva condicional
`while` cuya condición de control es un acumulador que se incrementa dentro del
bucle. Para la función `simula_30()` en C# usamos la estructura de control
condicional `switch` en lugar de `if-elif-else` porque para este caso es la más
adecuada, aunque también podríamos haber utilizado una secuencia de estructuras
`if-else` como hemos hecho antes.

```csharp
Console.WriteLine("C#");
Functions.Average20();
Functions.Simulate30();

public static class Functions
{
    public static int DrawDice()
    {
        return new Random().Next(1, 6);
    }

    public static void Average20()
    {
        int i = 0;
        int total = 0;
        while (i < 20)
        {
            int dice1 = DrawDice();
            int dice2 = DrawDice();
            total += dice1 + dice2;
            i = i + 1;
        }

        Console.WriteLine("Promedio suma:" + (total / 20).ToString());
    }

    public static void Simulate30()
    {
        int i = 0;
        int face1 = 0, face2 = 0, face3 = 0, face4 = 0, face5 = 0, face6 = 0;
        while (i < 30)
        {
            int dado = DrawDice();
            switch (dado)
            {
                case 1:
                    face1 += 1;
                    break;
                case 2:
                    face2 += 1;
                    break;
                case 3:
                    face3 += 1;
                    break;
                case 4:
                    face4 += 1;
                    break;
                case 5:
                    face5 += 1;
                    break;
                case 6:
                    face6 += 1;
                    break;
            }

            i += 1;
        }

        Console.WriteLine("cara 1:" + face1.ToString());
        Console.WriteLine("cara 2:" + face2.ToString());
        Console.WriteLine("cara 3:" + face3.ToString());
        Console.WriteLine("cara 4:" + face4.ToString());
        Console.WriteLine("cara 5:" + face5.ToString());
        Console.WriteLine("cara 6:" + face6.ToString());
    }
}
```

Puedes ver y ejecutar el código [aquí](./Ejercicio_5/Ejercicio_5.cs).

Algunas diferencias:

| Python | C# |
|--------|----|
| Es necesario importar el módulo `random` para usar `random.randint()` | La clase `Random` está en el espacio de nombres `System` que se importa de forma predeterminada |
| `randint()` es un método de la case `random` | `Next()` es un método de instancia de la clase `Random`; por eso es necesario crear una instancia con `new` |
| Múltiples variables se inicializan poniendo `=` seguido de los valores iniciales de todas ellas | Cada variable se inicializa por separado |

# Ejercicio 6

## Algoritmo en lenguaje natural

Crear una función "pangrama" que recibe una cadena de caracteres e indica si la
misma es un pangrama. Un pangrama es una cadena de caracteres que contiene todas
las letras posibles del alfabeto ya sea en mayúsculas o minúsculas (español
para nuestro caso).

Probar la función con los siguientes ejemplos:

|Texto|Pangrama|
|-|-|
|El viejo Señor Gómez pedía queso, kiwi y habas, pero le ha tocado un saxofón | Es un pangrama    |
|José compró una vieja zampoña en Perú. Excusándose, Sofía tiró su whisky al desagüe de la banqueta"| Es un pagrama|
|El cadáver de Wamba, rey godo de España, fue exhumado y trasladado en una caja de zinc que pesó un kilo| Es un pangrama|
|Compañera usted sabe que puede contar conmigo no hasta dos ni hasta diez sino contar conmigo.| No es un pangrama|

Antes de evaluar la cadena es necesario convertir las letras con tilde a letras
sin tilde; además, convertir todas las letras a minúsculas para simplificar la
búsqueda —daría lo mismo si convirtiéramos todas a mayúsculas—. Luego, para cada
letra del alfabeto, ls buscamos en la cadena; si no está, ya sabemos que no es
un pangrama; si está seguimos con la siguiente letra.

## Código Python

Una forma de implementar en Python la estructura repetitiva condicional "para
cada letra del alfabeto" es definir una cadena `alfabeto =
"abcdefghijklmnñopqrstuvwxyz"` y luego con `for letra in alfabeto` recorrer esa
cadena, es decir, cada letra del alfabeto.

```python
def normalize_string(string_to_normalize):
    accented_characters = "áéíóúü"
    normalized_characters = "aeiouu"
    normalized_string = ""
    for letter in string_to_normalize.lower():
        index_of_accented_character = accented_characters.find(letter)
        if index_of_accented_character >= 0:
            normalized_string += normalized_characters[index_of_accented_character]
        else:
            normalized_string += letter
    return normalized_string


def is_pangram(input_string):
    alphabet = "abcdefghijklmnñopqrstuvwxyz"
    normalized_string = normalize_string(input_string)
    for letter in alphabet:
        if letter not in normalized_string:
            return False
    return True

print("Python")
print(is_pangram("El viejo Señor Gómez pedía queso, kiwi y habas, pero le ha tocado un saxofón")) # True
print(is_pangram("José compró una vieja zampoña en Perú. Excusándose, Sofía tiró su whisky al desagüe de la banqueta")) # True
print(is_pangram("El cadáver de Wamba, rey godo de España, fue exhumado y trasladado en una caja de zinc que pesó un kilo")) # True
print(is_pangram("Compañera usted sabe que puede contar conmigo no hasta dos ni hasta diez sino contar conmigo.")) # False
```

Puedes ver y ejecutar el código [aquí](./Ejercicio_6/Ejercicio_6.py).

## Código C#

La clase `Functions` va a tener en este caso los métodos `string
NormalizeString(string)` y `bool IsPangram(string)`. La estructura repetitiva
`for-in` the Python corresponde en este caso en C# a la estructura repetitiva
[`foreach`](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement).
Al igual que `for-in`, `foreach` visita cada elemento del contenedor indicado,
en este caso una cadena de caracteres.

```csharp
Console.WriteLine("C#");
Console.WriteLine(Functions.IsPangram(
    "El viejo Señor Gómez pedía queso, kiwi y habas, pero le ha tocado un saxofón")); // True
Console.WriteLine(Functions.IsPangram(
    "José compró una vieja zampoña en Perú. Excusándose, Sofía tiró su whisky al desagüe de la banqueta")); // True
Console.WriteLine(Functions.IsPangram(
    "El cadáver de Wamba, rey godo de España, fue exhumado y trasladado en una caja de zinc que pesó un kilo")); // True
Console.WriteLine(Functions.IsPangram(
        "Compañera usted sabe que puede contar conmigo no hasta dos ni hasta diez sino contar conmigo.")); // False

public static class Functions
{
    public static string NormalizeString(string stringToNormalize)
    {
        string accentedChars = "áéíóúü";
        string normalizedChars = "aeiouu";
        string normalizedString = "";
        foreach (char letter in stringToNormalize.ToLower())
        {
            int indexOfAccentedChar = accentedChars.IndexOf(letter);
            if (indexOfAccentedChar >= 0)
            {
                normalizedString += normalizedChars[indexOfAccentedChar];
            }
            else
            {
                normalizedString += letter;
            }
        }

        return normalizedString;
    }

    public static bool IsPangram(string inputString)
    {
        string alphabet = "abcdefghijklmnñopqrstuvwxyz";
        string normalizedInput = NormalizeString(inputString);
        foreach (char letter in alphabet)
        {
            if (normalizedInput.IndexOf(letter) < 0)
            {
                return false;
            }
        }

        return true;
    }
}
```

Algunas diferencias:

|Python|C#|
|-|-|
|El método `find` de la clase `string` retorna el índice del elemento buscado o -1 si no existe|El método `IndexOf(string)` de la clase `String` es el equivalente en C#|
|Los operadores `in` y `not in` permiten determinar si un carácter es parte de una cadena o no|El método `IndexOf(char)` de la clase `String`permite determinar si un caracter es parte o no de una cadena|

Puedes ver y ejecutar el código [aquí](./Ejercicio_6/Ejercicio_6.cs).

# Ejercicio 7

## Algoritmo en lenguaje natural

Definir una función que permita generar un cartón de lotería. Un cartón de
lotería contiene 3 filas con 5 números cada una. Los números son aleatorios
entre 1 y 99 y no se repiten. La función debe retornar una lista conteniendo las
3 filas, es decir 3 listas, con 5 números cada una.

Por ejemplo:

```python
generate_lottery_board() -> [[13,10,11,16,15],[1,8,62,36,45],[99,97,85,73,28]]
```

Un enfoque para resolver este problema es generar primero los 15 números
aleatorios únicos, y luego crear 3 filas de 5 números cada una a partir de los
números aleatorios generados. Podemos ir guardando los números a medida que se
generan en una lista, generar un numero número aleatorio hasta que sea único,
agregarlo a la lista; y repetir este proceso 15 veces.

Como generar un nuevo número aleatorio es algo que haremos varias veces —15 para
ser exactos— podemos programar eso en una función. La función tiene que recibir
la lista para conocer los números generados previamente. Genera un número
aleatorio y continúa generando números aleatorios mientras el número generado
esté en la lista. Cuando el número generado no está en la lista, lo agrega. La
estructura de repetición condicional para esto es `while`. La repetición puede
ser controlada por una bandera que indique si el número generado está en la
lista, para que la repetición termine cuando no lo esté.

Esa función debe ser usada 15 veces, para generar los 15 números aleatorios y
agregarlos en una lista. La estructura de repetición condicional en este caso es
`for` porque la cantidad de veces que se debe petir el código es conocida de
antemano.

## Código Python

Llamemos `number` al número aleatorio generado y `number_in_list` a la bandera
que controla la repetición condicional. La función quedaría así:

```python
def generate_new_number(numbers_list):
    number = random.randint(1, 99)
    number_in_list = number in numbers_list
    while number_in_list:
        number = random.randint(1, 99)
        number_in_list = number in numbers_list
    numbers_list.append(number)
```

El código hace exactamente lo que debe, pero repite un par de líneas. Una forma
análoga sería:

```python
def generate_new_number(numbers_list):
    number = 0
    number_in_list = True
    while number_in_list:
        number = random.randint(1, 99)
        number_in_list = number in numbers_list
    numbers_list.append(number)
```

La bandera `number_in_list` se asigna en `True` antes de la estructura `while`,
por lo que la primera vez entra a la repetición. Allí se genera un número
aleatorio y se asigna la bandera `number_in_list` con `True` o `False`
dependiendo de que el número esté en la lista o no, respectivamente. El operador
`in` se usa para determinar si el número está en la lista o no.

La otra función simplemente llama a `generate_new_numbers` 15 veces, y luego usa
los primeros 5 números para la fila 1, los segundos 5 para la fila 2, y los
terceros 5 para la fila 3. Para separar la lista en las fila usamos el *slicing*
de Python.

```python
def generate_lottery_board():
    lottery_numbers = []

    for i in range(15):
        generate_new_number(lottery_numbers)

    row1 = lottery_numbers[0:5]
    row2 = lottery_numbers[5:10]
    row3 = lottery_numbers[10:15]

    lottery_board = [row1, row2, row3]
    return lottery_board
```

Puedes ver y ejecutar el código [aquí](./Ejercicio_7/Ejercicio_7.py).

## Código C#

El siguiente fragmento de código muestra una posible implementación equivalente
en C# de la función que genera un nuevo número aleatorio y lo agrega a la lista.
La función no es libre como en Python sino un método de una clase, que como en
los ejemplos anteriores es la clase `Functions`.

Recuerda que en C# hay que declarar el tipo de los parámetros, de las variables,
y de los resultados de las funcioens. El método `GenerateNewUniqueNumber` recibe como parámetro
la lista de números `numbersList` de tipo `List<int>`. Este tipo indica que
`numberLists` es una lista y que esa lista puede tener sólo números. Verás más
adelante en el curso que esto es un tipo genérico, pero por ahora solo recuerda
que en C# puedes definir listas, pero debes decir el tipo de elementos de la
lista.

> [!NOTE]
> Existe otra clase `ArrayList` que también es una lista pero puede contener
> objetos de cualquier tipo; preferimos usar `List<T>`, donde `T` puede ser
> cualquier tipo, en este caso `int`.

```csharp
public static class Functions
{
    public static void GenerateNewUniqueNumber(List<int> numbersList)
    {
        int number;
        bool numberInList;
        do
        {
            number = (new Random()).Next(1, 100);
            numberInList = numbersList.Contains(number);
        } while (numberInList);

        numbersList.Add(number);
    }
}
```

En lugar de una estructura repetitiva condicional `while` en codigo en C# usa la
estructura `do-while` como ya hemos hecho anteriormente. Esto es porque al menos
una vez hay que generar un número aleatorio y continuar iterando sólo si ese número
está en la lista, con lo cual es más adecuado evaluar la condición al final de
la repetición —que es lo que hace `do-while`— y no al comienzo —que es lo que
hace `while`—.

Otras diferencias:

|Python|C#|
|-|-|
|Para generar un número aleatorio entre 1 y 99 se usa el método de clase `randint(1, 99)` de la clase `random`; se incluye el límite superior|Un número aleatorio entre 1 y 99 se genera con el método `Next(1, 100)` de la clase `Random`; es necesario crear una instancia de `Random` para usar ese método; el límite superior no se incluye|
|El operador `in` permite determinar si un elemento está en una lista|El método `Contains` de la clase `List<T>` permite determinar si un elemento está en una lista|

El otro método de la clase `Functions` implementa la función para generar el
tablero:

```csharp
public static class Functions
{
    public static List<List<int>> GenerateLotteryBoard()
    {
        List<int> lotteryNumbers = new List<int>();

        for (int i = 0; i < 15; i++)
        {
            GenerateNewUniqueNumber(lotteryNumbers);
        }

        List<int> row1 = lotteryNumbers.GetRange(0, 5);
        List<int> row2 = lotteryNumbers.GetRange(5, 5);
        List<int> row3 = lotteryNumbers.GetRange(10, 5);

        List<List<int>> lotteryBoard = new List<List<int>>() { row1, row2, row3 };
        return lotteryBoard;
    }
}
```

Algunas diferencias con Python:

|Python|C#|
|-|-|
|`[]` crea una lista vacía|Para crear una lista `List<int>` se usa `new List<int>()`|
|La estructura de control condicional `for` para iterar una cantidad `X` de veces se usa con `for i in range(X)`|Para iterar una cantidad `X` de veces se usa `for (int i = 0; i < X; i++)`|
|Para obtener del `i`-ésimo al `j`-ésimo elemento de una lista se usa `[i:j]`|El método `GetRange(i, j)` permite obtener del `i`-ésimo al `j`-ésimo elemento de una lista|
|`[e1, e2, ...]` crea una lista con elementos `e1`, `e2`, etc.|Para crear una lista con elementos `e1`, `e2`, etc. se usa `new List<T>() { e1, e2, ...}`|

> [!NOTE]
> El resultado del método `GenerateLotteryBoard` es de tipo `List<List<int>>`
> que es una lista cuyos elementos son listas de enteros.

El programa principal que usa esas funciones queda así:

```csharp
Console.WriteLine("C#");
Console.Write("[");
foreach (var row in Functions.GenerateLotteryBoard())
{
    Console.Write("[");
    Console.Write(String.Join(",", row));
    Console.Write("]");
}
Console.Write("]");
```

Nota que si pasas una lista a `Console.WriteLine()` no se imprimirán los
elementos como sucede en Python. Es necesario iterar por las listas imprimiendo
cada uno de sus elementos con `for-each`. Cuando la lista contiene tipos de
datos elementales como `int` o `string` puedes usar `String.Join(char, List<T>)`
que convierte los elementos de la lista a una cadena separándolos con el
carácter indicado como primer parámetro.

Puedes ver y ejecutar el código [aquí](./Ejercicio_7/Ejercicio_7.cs).