# Objetivo

Recordar estructuras de control de flujo y estructuras de repetición condicional en algoritmos expresados en lenguaje natural y su correspondiente implementación en Python; a partir del algoritmo en lenguaje natural y en Python, ver cómo se implementan esos algoritmos en C#.

> [!IMPORTANT]
> En este repositorio los algoritmos en C# están implementados como métodos estáticos en la clase `Program`. No recomendamos que hagas tus programas con todo el código en un solo método estático de la clase `Program`, aquí lo hacemos de esta forma para que sea más fácil mostrar la equivalencia con las funciones que programabas en Python.

Este repositorio contiene ejemplos de código en Python y en C#.

Cuando abras los archivos `.py` de Python, Rider te sugerirá instalar el complemento [Python Community Edition](https://plugins.jetbrains.com/plugin/7322-python-community-edition), pero no te preocupes de hacerlo ahora; sigue las instrucciones cuando Rider te lo pregunte.

> [!NOTE]
> En el código Python los algoritmos están implementados en una función definida al comienzo del programa; esa función se usa con algunos ejemplos para mostrar su funcionamiento en el programa principal que está luego de la función. En el código en C# los algoritmos están implementados en un método estático al comienzo de la clase `Program`; ese método se usa con algunos ejemplos en el método `Main` de la clase `Program`.
> 
> Para ejecutar el código clona y abre este repositorio en Rider primero. Vas a ver en la esquina superior derecha de Rider una lista desplegable con los nombres de los ejemplos y al lado el icono ![](https://intellij-icons.jetbrains.design/icons/AllIcons/expui/run/run_dark.svg); haz clic en este ícono para ejecutar el ejemplo.

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
      Es necesario declarar siempre el tipo de los parámetros; en este caso el tipo es  que corresponde a enteros
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

Aquí ya puedes ver algunas diferencias en la filosofía subyacente en ambos lenguajes. Mientras en Python el lenguaje asume tipos de datos, hace conversiones automáticas, etc. en C# el programador debe anunciar su intención y realizar él las conversiones necesarias. Esto no es un regla a raja tabla, hay excepciones, pero en términos generales se cumple esto. Las diferencias no son ni buenas ni malas, ambos son lenguajes muy utilizados y tienen su comunidad de seguidores. Ya te vas a acostumbrar.

# Ejercicio 2

## Algoritmo en lenguaje natural

Un programa lee el candidato por el cual el usuario va a votar. Las posibilidades son: candidato `A` por el partido rojo, candidato `B` por el partido verde, candidato `C` por el partido azul. Según el candidato elegido —`A`, `B` ó `C`, en forma de string— se imprimirá el mensaje "Usted ha votado por el partido [color que corresponda al candidato elegido]". Si el usuario ingresa una opción que no corresponde a ninguno de los candidatos disponibles, imprimir "Opción errónea".

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

# Ejercicio 3

## Algoritmo en lenguaje natural

Escribir un programa que lea el día de la semana en letras —por ejemplo, "lunes"— e imprima el siguiente mensaje:
- Si es lunes imprima "Hoy comienza la semana. ¡Animo!",
- Si es viernes "¡Ya casi termina!"
- Si es sábado o domingo “¡Siiii! ¡Fin de semana!”
- Si el día ingresado no es ninguno de esos (pero es válido), imprimir el siguiente mensaje "¡Vamos que se puede!"
- Si el día ingresado no es válido entonces debe mostrar un mensaje que lo indique

## Código en Python

Es necesario determinar cuál es el día de la semana; eso se hace con la estructura de control `if-elif-else` evaluando múltiples condiciones, aunque en algún caso será necesario combinar las condiciones, por ejemplo para "sábado o domingo".

```python
def mensaje(dia_semana):
    if dia_semana.lower() == "lunes":
        print("Hoy comienza la semana. ¡Ánimo!")
    elif dia_semana.lower() == "viernes":
        print("Ya casi termina!")
    elif dia_semana.lower() == "sábado" or \
            dia_semana.lower() == "domingo":
        print("¡Siiii! ¡Fin de semana!")
    elif (dia_semana.lower() == "martes" or
          dia_semana.lower() == "miércoles" or
          dia_semana.lower() == "jueves"):
        print("¡Vamos que se puede!")
    else:
        print("¡Dia de la semana invalido!")


dia_sem = input("Ingrese el día de la semana > ")
mensaje(dia_sem)
```

Vean el uso de `or` para evaluar si el día de la semana es "sábado o domingo" por ejemplo. Podría haber un `elif` con la condición `dia_semana.lower() == sábado` para evaluar si el día es sábado y otro con la condición `dia_semana.lower() == domingo` para evaluar si es domingo, pero como en ambos casos hay que mostrar el mismo mensaje, entonces es mejor usar `or` para evaluar si es sábado o si es domingo.

## Código en C#

Nuevamente, la estructura de control a usar en C# es una concatenación de estructuras de control `if-else` como en el ejemplo anterior. El método estático `Mensaje()` de la clase `Program` sería el equivalente a la función `mensaje()` en Python.

```csharp
static class Program
{
    static void Mensaje(string diaSemana)
    {
        if (diaSemana.ToLower() == "lunes")
        {
        Console.WriteLine("Hoy comienza la semana. !Ánimo!");
        }
        else if (diaSemana.ToLower() == "viernes")
        {
        Console.WriteLine("¡Ya casi termina!");
        }
        else if (diaSemana.ToLower() == "sábado"
            || diaSemana.ToLower() == "domingo")
        {
        Console.WriteLine("¡Siiii! ¡Fin de semana!");
        }
        else if (diaSemana.ToLower() == "martes"
            || diaSemana.ToLower() == "miércoles"
            || diaSemana.ToLower() == "jueves")
        {
            Console.WriteLine("¡Vamos que se puede!");
        }
        else
        {
            Console.WriteLine("¡Dia de la semana invalido!");
        }
    }

    static void Main()
    {
        Console.WriteLine("C#");
        Console.Write("Ingrese el día de la semana > ");
        string diaSem = Console.ReadLine();
        Mensaje(diaSem);
    }
}
```

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

Dicho sea de paso, vieron que para comparar si dos elementos son iguales, tanto Python como C# usan el operador `==`; los operadores de comparación son iguales en ambos lenguajes, esto aplica para `<`, `<=`,`>`, `>=`, `==`, `!=`.

También son iguales los operadores aritméticos `+`, `-`, `*`, `/`, `+=`, `-=`, `*=`, `/=`[^2].

[^1]: La diferencia es si se evalúa el segundo operando. Ver [and](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators#logical-and-operator-) y [or](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators#conditional-logical-and-operator-).
[^2]: Mientras `/=` aplicado a objetos de tipo `int` en Python da como resultado un objeto de tipo `float`, en C# da un objeto de tipo `int` siempre. Ver [division operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/division-operator).

# Ejercicio 4

## Algoritmo en lenguaje natural

Escribir un programa que lea números desde el teclado, hasta que el usuario ingrese el 0. Finalmente, mostrar la sumatoria de todos los números positivos ingresados —solo de los números que sean positivos—.

## Código en Python

Es necesario leer un número y luego continuar leyendo repetidamente mientras el usuario no ingrese el número cero. Esto se logra con la estructura repetitiva condicional `while`. Para obtener la sumatoria de todos los números usamos un acumulador.

```python
suma = 0
numero = int(input("Ingrese número (0 para terminar): "))
while numero != 0:
    if numero > 0:
        suma = suma + numero
    numero = int(input("Ingrese número (0 para terminar): "))
print("La suma es: ", suma)
```

Puedes ver y ejecutar el programa [aquí](./Ejercicio_4/Ejercicio_4.py)

## Código en C#

El algoritmo en C# se implementa también con la estructura repetitiva condicional `while`.>

> [!IMPORTANT]
> Aunque la forma como escribes un `while` en Python y en C# sea diferente, si sabes determinar la estructura repetitiva condicional en Python a partir del texto en lenguaje natural, basta con que sepas cómo escribir esa estructura en C#, porque la estructura repetitiva condicional en sí debería ser la misma.

```csharp
static class Program
{
    static void Main()
    {
        Console.WriteLine("C#");
        int suma = 0;
        Console.Write("Ingrese número (0 para terminar): ");
        int numero = int.Parse(Console.ReadLine());
        while (numero != 0)
        {
            if (numero > 0)
            {
                suma = suma + numero;
            }

            Console.Write("Ingrese número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("La suma es: " + suma.ToString());
    }
}
```

Puedes ver y ejecutar el código [aquí](./Ejercicio_4/Ejercicio_4.cs).

Noten que como no hay ninguna función definida en Python, todo el código en C# va dentro del método `Main` de la clase `Program`, eso sería una forma equivalente de escribir el programa en ambos lenguajes.

La estructura `while` es prácticamente igual en ambos lenguajes; algunas diferencias a continuación:

| Python                                                    | C#                                                   |
|-----------------------------------------------------------|------------------------------------------------------|
| Los paréntesis son opcionales en la condición del `while` | La condición del `while` va siempre entre paréntesis |
| `int()` se utiliza para convertir una string en un entero | `int.Parse()` convierte una string en un entero      |


C# tiene otra estructura repetitiva condicional similar a `while` pero que controla la condición **luego** de ejecutar el bloque de código asociado: la estructura `do-while`. En este caso puede ser mejor —mostramos sólo el método `Main`—.

```csharp
static void Main()
{
    Console.WriteLine("C#");
    
    int suma = 0;
    int numero;
    do
    {
        Console.Write("Ingrese número (0 para terminar): ");
        numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            suma = suma + numero;
        }
    } while (numero != 0);
    

    Console.WriteLine("La suma es: " + suma.ToString());
}
```

Esta versión del método `Main` está comentada [aquí](./Ejercicio_4/Ejercicio_4.cs); comenta la versión con `while` y quita los comentarios a esta version con `do-while` para ejecutarla.

> [!TIP]
> Puedes comentar o quitar los comentarios rápidamente bloques de código con las teclas <kbd>Ctrl</kbd>+<kbd>/</kbd> en Windows o <kbd>Cmd</kbd>+<kbd>/</kbd> en Mac y Linux.

