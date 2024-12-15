// Clase que representa un Círculo
public class Circulo
{
    private double radio; // Radio del círculo, encapsulado como un atributo privado

    // Constructor para inicializar el radio
    public Circulo(double radioInicial)
    {
        radio = radioInicial;
    }

    // Propiedad para acceder y modificar el radio
    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }

    // Método para calcular el área del círculo
    public double CalcularArea()
    {
        // Fórmula: π * radio^2
        return Math.PI * Math.Pow(radio, 2);
    }

    // Método para calcular el perímetro del círculo
    public double CalcularPerimetro()
    {
        // Fórmula: 2 * π * radio
        return 2 * Math.PI * radio;
    }
}

// Clase que representa un Rectángulo
public class Rectangulo
{
    private double largo; // Largo del rectángulo
    private double ancho; // Ancho del rectángulo

    // Constructor para inicializar largo y ancho
    public Rectangulo(double largoInicial, double anchoInicial)
    {
        largo = largoInicial;
        ancho = anchoInicial;
    }

    // Propiedades para acceder y modificar largo y ancho
    public double Largo
    {
        get { return largo; }
        set { largo = value; }
    }

    public double Ancho
    {
        get { return ancho; }
        set { ancho = value; }
    }

    // Método para calcular el área del rectángulo
    public double CalcularArea()
    {
        // Fórmula: largo * ancho
        return largo * ancho;
    }

    // Método para calcular el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        // Fórmula: 2 * (largo + ancho)
        return 2 * (largo + ancho);
    }
}

// Clase principal para probar las figuras geométricas
class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto de tipo Circulo
        Circulo circulo = new Circulo(5); // Radio = 5
        Console.WriteLine("Círculo:");
        Console.WriteLine("Radio: " + circulo.Radio);
        Console.WriteLine("Área: " + circulo.CalcularArea());
        Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());

        // Crear un objeto de tipo Rectangulo
        Rectangulo rectangulo = new Rectangulo(10, 4); // Largo = 10, Ancho = 4
        Console.WriteLine("\nRectángulo:");
        Console.WriteLine("Largo: " + rectangulo.Largo);
        Console.WriteLine("Ancho: " + rectangulo.Ancho);
        Console.WriteLine("Área: " + rectangulo.CalcularArea());
        Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());
    }
}
