// Req1 - Opción del menú
int opcion;

// Mostrar menú principal
Console.WriteLine("Bienvenido a Red Majestic\n");
Console.WriteLine("Operar con Visa - Ingrese 1");
Console.WriteLine("Operar con Mastercard - Ingrese 2");
Console.WriteLine("Operar con Diners Club - Ingrese 3\n");
Console.Write("Ingrese su opción: ");

// Leer opción como int
opcion = int.Parse(Console.ReadLine());

// Limpiar consola antes de solicitar tarjeta
Console.Clear();

// Req2 - Número de tarjeta como string
string numeroTarjeta;
Console.Write("Ingrese el número de tarjeta: ");
numeroTarjeta = Console.ReadLine();

// Req3 - Identificador de empresa como string (primeros 4 dígitos)
string identificador = numeroTarjeta.Substring(0, 4);

// Req4 - Últimos cuatro dígitos como string
string ultimosCuatroDígitos = numeroTarjeta.Substring(numeroTarjeta.Length - 4);
