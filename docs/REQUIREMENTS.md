# Requirements - Red Majestic

## 1. Contexto del sistema

Red Majestic es una red interbancaria que brinda a sus clientes servicios de consulta de movimientos transaccionales realizados con tarjetas de crédito.

Actualmente opera con:

- Visa
- Mastercard
- Diners Club

El sistema se desarrolla como una prueba de concepto académica mediante una aplicación de consola en C#.

---

## 2. Menú principal

Al iniciar la aplicación, el sistema deberá mostrar:

Bienvenido a Red Majestic

Operar con Visa - Ingrese 1  
Operar con Mastercard - Ingrese 2  
Operar con Diners Club - Ingrese 3  

Ingrese su opción:

La opción seleccionada deberá almacenarse en una variable de tipo entero.

---

## 3. Ingreso de tarjeta

Luego de seleccionar una opción, el sistema deberá limpiar la pantalla y solicitar al usuario el número de tarjeta de crédito.

El número ingresado:

- tendrá 16 dígitos;
- deberá almacenarse en una variable de tipo `string`;
- será utilizado para obtener el identificador de la empresa;
- será utilizado para obtener los últimos 4 dígitos.

---

## 4. Identificadores de tarjetas

Para la implementación se utilizarán los siguientes identificadores definidos en los requerimientos técnicos:

- Visa: `4407`
- Mastercard: `3890`
- Diners Club: `7401`

El identificador deberá extraerse del número de tarjeta y almacenarse en una variable de tipo `string`.

---

## 5. Últimos cuatro dígitos

El sistema deberá extraer los últimos cuatro dígitos del número de tarjeta y almacenarlos en una variable de tipo `string`.

Esta información deberá utilizarse al mostrar los movimientos de la cuenta.

Ejemplo:

Movimiento de su cuenta Visa terminada en ..3210

---

# Requerimientos funcionales y técnicos

## Req1 - Opción del menú

La opción ingresada por el usuario en el menú principal deberá almacenarse en una variable de tipo entero.

---

## Req2 - Número de tarjeta

El número de tarjeta ingresado por el usuario deberá almacenarse en una variable de tipo `string`.

---

## Req3 - Identificador de empresa

El sistema deberá extraer del número de tarjeta el identificador de la empresa y almacenarlo en una variable de tipo `string`.

Esta variable se utilizará para realizar las validaciones junto con la opción ingresada por el usuario.

---

## Req4 - Últimos cuatro dígitos

El sistema deberá extraer los últimos cuatro dígitos de la tarjeta y almacenarlos en una variable de tipo `string`.

Esta información se utilizará para mostrar el título de los movimientos de cuenta.

---

## Req5 - Validación general de tarjeta

El sistema deberá validar la tarjeta llamando a una función que:

- devuelva un valor booleano;
- reciba como parámetros:
  - el identificador de la tarjeta;
  - la opción ingresada por el usuario.

La función deberá utilizar una estructura `switch`.

Según la opción ingresada, deberá invocar la función de validación específica correspondiente.

La función deberá devolver `false` por defecto y solamente devolver `true` cuando la validación específica sea correcta.

---

## Req6 - Validación Visa

La función de validación de Visa deberá:

- recibir el identificador de la tarjeta;
- comparar el valor recibido con una constante local igual a `4407`;
- devolver `true` si son iguales;
- devolver `false` en caso contrario.

---

## Req7 - Validación Mastercard

La función de validación de Mastercard deberá:

- recibir el identificador de la tarjeta;
- comparar el valor recibido con una constante local igual a `3890`;
- devolver `true` si son iguales;
- devolver `false` en caso contrario.

---

## Req8 - Validación Diners Club

La función de validación de Diners Club deberá:

- recibir el identificador de la tarjeta;
- comparar el valor recibido con una constante local igual a `7401`;
- devolver `true` si son iguales;
- devolver `false` en caso contrario.

---

## Req9 - Resultado de validación

Si la tarjeta fue validada correctamente, el sistema deberá ejecutar la lógica definida en Req10.

Si la validación falla:

- si la opción ingresada es incorrecta, mostrar:

`La opción ingresada no es válida. Inténtelo nuevamente más tarde.`

- en caso contrario, mostrar:

`El número de tarjeta ingresada no es válido. Inténtelo nuevamente más tarde.`

La lógica deberá realizarse utilizando estructuras condicionales dobles.

---

## Req10 - Obtención y visualización de transacciones

La lógica de este requerimiento deberá formar parte del programa principal y utilizar una estructura condicional múltiple.

### Visa

Si la opción seleccionada corresponde a Visa:

- llamar a una función que devuelve un vector `float[]`;
- pasar como parámetro el identificador de la tarjeta;
- mostrar las transacciones utilizando una estructura `while`;
- utilizar el contador de la estructura como número de transacción.

### Mastercard

Si la opción seleccionada corresponde a Mastercard:

- llamar a una función que devuelve una `List<float>`;
- pasar como parámetro el identificador de la tarjeta;
- mostrar las transacciones utilizando una estructura `do-while`;
- utilizar un contador como número de transacción.

### Diners Club

Si la opción seleccionada corresponde a Diners Club:

- llamar a una función que devuelve un `Dictionary<int, float>`;
- pasar como parámetro el identificador de la tarjeta;
- mostrar las transacciones utilizando una estructura `foreach`;
- utilizar la clave de cada elemento como número de transacción.

---

## Req11 - Transacciones Visa

La función de transacciones Visa deberá:

- devolver un vector `float[]`;
- inicializar un vector de 5 elementos;
- recibir el identificador de tarjeta;
- validar el identificador invocando la función definida en Req6;
- si la validación es correcta, cargar los 5 elementos con valores aleatorios;
- utilizar una estructura `for` para cargar el vector;
- utilizar la función `GenerateRandomTransaction()` para generar los montos.

---

## Req12 - Transacciones Mastercard

La función de transacciones Mastercard deberá:

- devolver una `List<float>`;
- inicializar una lista;
- recibir el identificador de tarjeta;
- validar el identificador invocando la función definida en Req7;
- si la validación es correcta, cargar 5 elementos con valores aleatorios;
- utilizar una estructura `for`;
- utilizar la función `GenerateRandomTransaction()` para generar los montos.

---

## Req13 - Transacciones Diners Club

La función de transacciones Diners Club deberá:

- devolver un `Dictionary<int, float>`;
- inicializar un diccionario;
- recibir el identificador de tarjeta;
- validar el identificador invocando la función definida en Req8;
- si la validación es correcta, cargar 5 elementos;
- cada elemento deberá utilizar:
  - clave `int`;
  - valor `float`;
- utilizar una estructura `for`;
- utilizar el índice del `for` como clave;
- utilizar la función `GenerateRandomTransaction()` para generar los montos.

---

# Visualización de transacciones

Ejemplo para Visa:

Movimiento de su cuenta Visa terminada en ..3210

Transacción Nº 1 - Monto $1500,00  
Transacción Nº 2 - Monto $200,00

La presentación deberá mantener una experiencia de usuario clara.

---

# Finalización

Luego de mostrar las transacciones o un mensaje de error, el sistema deberá esperar que el usuario presione cualquier tecla antes de finalizar su ejecución.

---

# Función provista en el anexo

```csharp
public static float GenerateRandomTransaction()
{
    Random rand = new Random();
    return (float)rand.NextDouble() * 1000;
}