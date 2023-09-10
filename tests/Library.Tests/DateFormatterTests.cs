using Ucu.Poo.TestDateFormat;

namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestDateValid()
    {
        string fecha = "10/10/2004";
        string fechaEsperada = "2004-10-10";
        string resultado = DateFormatter.ChangeFormat(fecha);
        Assert.AreEqual(resultado,fechaEsperada);
    }
    [Test]
    public void TestDateInvalidFormat()
    {
        // Una fecha que no tiene el formato correcto
        string fecha = "10/2004/7"; // Formato incorrecto
        string fechaEsperada = ""; // La fecha debería ser una cadena vacía
        string resultado = DateFormatter.ChangeFormat(fecha);
        Assert.That(resultado, Is.EqualTo(fechaEsperada));
    }

    [Test]
    public void TestVoid()
    {
        // Una fecha en blanco
        string fecha = ""; // Fecha en blanco
        string fechaEsperada = ""; // La fecha debería ser una cadena vacía
        string resultado = DateFormatter.ChangeFormat(fecha);
        Assert.That(resultado, Is.EqualTo(fechaEsperada));
    }

}