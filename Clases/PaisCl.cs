using static System.Console;
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