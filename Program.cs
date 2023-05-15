using static System.Console;

Clear();
Write("Ingrese el nombre del país (México/Japón/España):");
string? nombre = Console.ReadLine();

Write("Ingrese la capital del país:");
string? capital = Console.ReadLine();

Pais? pais = null;

switch (nombre)
{
    case "México":
        Write("Ingrese el idioma del país:");
        string? idioma = ReadLine();
        pais = new Mexico(nombre!, capital!, idioma!);
        break;
    case "Japón":
        Write("Ingrese moneda del país:");
        string? moneda = ReadLine();
        pais = new Japon(nombre!, capital!, moneda!);
        break;
    case "España":
        Write("Ingrese region del país:");
        string? region = ReadLine();
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
