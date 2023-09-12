using System;

namespace OOPClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Las siguientes clases se pueden instanciar y crear objetos de ellas ya que no son clases abstractas ni interfaces:
            Estudiante Francisco = new Estudiante();
            ExAlumno Angelys = new ExAlumno();
            Administrador admin = new Administrador();
            Maestro Francis = new Maestro();
            Administrativo administrativo = new Administrativo();

            /*
             Las clases IMiembroDeLaComunidad, Empleado y docente son Abstractas e Interfaces y por esta razon no pueden ser instanciadas
            solo cumplen el papel de proporcionar metodos y atributos a las clases de las que luego se crearan un objeto.
             */
        }
    }
}
