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

// Validar la tarjeta
bool esValido = ValidarTarjeta(identificador, opcion);

// Req9 - Resultado de validación
if (!esValido)
{
    // La tarjeta no es válida
    if (opcion < 1 || opcion > 3)
    {
        // La opción es incorrecta
        Console.WriteLine("La opción ingresada no es válida. Inténtelo nuevamente más tarde.");
    }
    else
    {
        // La opción es válida pero la tarjeta no
        Console.WriteLine("El número de tarjeta ingresada no es válido. Inténtelo nuevamente más tarde.");
    }
}
else
{
    // La validación fue correcta, aquí irá la lógica de Req10 (transacciones)
    // Req10 - Obtención y visualización de transacciones
    Console.Clear();

    switch (opcion)
    {
        case 1:
            // Visa - Req11
            {
                float[] transacciones = ObtenerTransaccionesVisa(identificador);
                Console.WriteLine($"Movimiento de su cuenta Visa terminada en ..{ultimosCuatroDígitos}\n");

                int contador = 1;
                while (contador <= transacciones.Length)
                {
                    Console.WriteLine($"Transacción Nº {contador} - Monto ${transacciones[contador - 1]:F2}");
                    contador++;
                }
            }
            break;

        case 2:
            // Mastercard - Req12
            {
                List<float> transacciones = ObtenerTransaccionesMastercard(identificador);
                Console.WriteLine($"Movimiento de su cuenta Mastercard terminada en ..{ultimosCuatroDígitos}\n");

                int contador = 1;
                do
                {
                    Console.WriteLine($"Transacción Nº {contador} - Monto ${transacciones[contador - 1]:F2}");
                    contador++;
                } while (contador <= transacciones.Count);
            }
            break;

        case 3:
            // Diners Club - Req13
            {
                Dictionary<int, float> transacciones = ObtenerTransaccionesDinersClub(identificador);
                Console.WriteLine($"Movimiento de su cuenta Diners Club terminada en ..{ultimosCuatroDígitos}\n");

                foreach (var elemento in transacciones)
                {
                    Console.WriteLine($"Transacción Nº {elemento.Key} - Monto ${elemento.Value:F2}");
                }
            }
            break;
    }
}

// Finalización - esperar que el usuario presione una tecla
Console.WriteLine();
Console.WriteLine("Presione cualquier tecla para finalizar...");
Console.ReadKey();

// Req6 - Validación Visa
bool ValidarVisa(string identificador)
{
    const string IDENTIFICADOR_VISA = "4407";
    return identificador == IDENTIFICADOR_VISA;
}

// Req7 - Validación Mastercard
bool ValidarMastercard(string identificador)
{
    const string IDENTIFICADOR_MASTERCARD = "3890";
    return identificador == IDENTIFICADOR_MASTERCARD;
}

// Req8 - Validación Diners Club
bool ValidarDinersClub(string identificador)
{
    const string IDENTIFICADOR_DINERS = "7401";
    return identificador == IDENTIFICADOR_DINERS;
}

// Req5 - Validación general de tarjeta
bool ValidarTarjeta(string identificador, int opcion)
{
    bool esValida = false;

    switch (opcion)
    {
        case 1:
            esValida = ValidarVisa(identificador);
            break;
        case 2:
            esValida = ValidarMastercard(identificador);
            break;
        case 3:
            esValida = ValidarDinersClub(identificador);
            break;
    }

    return esValida;
}

// Función para generar montos aleatorios de transacciones
static float GenerateRandomTransaction()
{
    Random rand = new Random();
    return (float)rand.NextDouble() * 1000;
}

// Req11 - Transacciones Visa
float[] ObtenerTransaccionesVisa(string identificador)
{
    float[] transacciones = new float[5];

    if (ValidarVisa(identificador))
    {
        for (int i = 0; i < transacciones.Length; i++)
        {
            transacciones[i] = GenerateRandomTransaction();
        }
    }

    return transacciones;
}

// Req12 - Transacciones Mastercard
List<float> ObtenerTransaccionesMastercard(string identificador)
{
    List<float> transacciones = new List<float>();

    if (ValidarMastercard(identificador))
    {
        for (int i = 0; i < 5; i++)
        {
            transacciones.Add(GenerateRandomTransaction());
        }
    }

    return transacciones;
}

// Req13 - Transacciones Diners Club
Dictionary<int, float> ObtenerTransaccionesDinersClub(string identificador)
{
    Dictionary<int, float> transacciones = new Dictionary<int, float>();

    if (ValidarDinersClub(identificador))
    {
        for (int i = 1; i <= 5; i++)
        {
            transacciones.Add(i, GenerateRandomTransaction());
        }
    }

    return transacciones;
}
