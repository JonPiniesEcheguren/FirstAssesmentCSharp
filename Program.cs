using static System.Console;

Clear();
Write("Ingrese el nombre del país (México/Japón/España):");
string? nombre = Console.ReadLine();
if (nombre == null)
    {
        Write("País inválido");
        return;
    }

Write("Ingrese la capital del país:");
string? capital = Console.ReadLine();
if (nombre == null)
    {
        Write("Capital de país inválido");
        return;
    }

Pais? pais = null;

switch (nombre)
{
    case "México":
        Write("Ingrese el idioma del país:");
        string? idioma = ReadLine();
        if (idioma == null)
    {
        Write("Idioma inválido");
        return;
    }
        pais = new Mexico(nombre!, capital!, idioma!);
        break;
    case "Japón":
        Write("Ingrese moneda del país:");
        string? moneda = ReadLine();
        if (moneda == null)
    {
        Write("Moneda inválida");
        return;
    }
        pais = new Japon(nombre!, capital!, moneda!);
        break;
    case "España":
        Write("Ingrese region del país:");
        string? region = ReadLine();
        if (region == null)
    {
        Write("Región invalida");
        return;
    }
        pais = new Espana(nombre!, capital!, region!);
        break;
    default:
        Write("Opción inválida");
        return;
}
if (pais != null)
    WriteLine(pais.Descripcion());
Write("Entre cualquier tecla");
ReadKey();
