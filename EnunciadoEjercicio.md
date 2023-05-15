# Escenario de Países: Código 03

Usted ha sido contratado para trabajar como `CSharp developer` en una empresa local de su ciudad.

El negocio central es el estudio económico de países de la OECD.

Usted iniciará un proyecto que incluirá la elaboración de `site` en Internet para la gestión de la información económica de los países basado en estudios de diversos sectores.

Las países que iniciales que se incorporarán al estudio son México, España y Japón, pero próximamente se añadirán mas países conforme vayan llegando los resultado de los estudios  económicos.

Debe crear el proyecto de iniciación para comenzar a desarrollar en las siguientes jornadas toda la aplicación.

Hoy deberá entregar la validación de funcionalidad, con la jerarquía de clases, y con el funcionamiento de una aplicación de consola; incluyendo toda la información proporcionada en este documento. Y completarlas según las instrucciones recibidas.

- Jerarquía de clases

```
Países: México, España, Japón.
```

``` CSharp
public abstract class Pais
{
    protected string nombre;
    protected string capital;

    public Pais(string nombre, string capital)
    {
        this.nombre = nombre;
        this.capital = capital;
    }

    public abstract string Descripcion();
}

public class Mexico : Pais
{
    private string idioma;

    public Mexico(string nombre, string capital, string idioma) : base(nombre, capital)
    {
        this.idioma = idioma;
    }

    public override string Descripcion()
    {
        return $"México es un país de América del Norte, cuya capital es {capital} y su idioma oficial es el {idioma}.";
    }
}

public class Japon : Pais
{
    private string moneda;

    public Japon(string nombre, string capital, string moneda) : base(nombre, capital)
    {
        this.moneda = moneda;
    }

    public override string Descripcion()
    {
        return $"Japón es un país de Asia, cuya capital es {capital} y su moneda oficial es el {moneda}.";
    }
}

public class Espana : Pais
{
    private string region;

    public Espana(string nombre, string capital, string region) : base(nombre, capital)
    {
        this.region = region;
    }

    public override string Descripcion()
    {
        return $"España es un país de Europa, cuya capital es {capital} y se encuentra en la región de {region}.";
    }
}
```

####  Aplicación principal

```CSharp
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
```

