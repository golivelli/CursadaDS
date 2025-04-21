// Se necesita desarrollar una aplicación por consola que nos ayude a almacenar y administrar la 
// información de los integrantes de las células de trabajo de un equipo de desarrollo. 
// Hay dos roles principales: desarrolladores y testers.
// Se necesita registrar su nombre, apellido y edad. 
// Además para los desarrolladores se requiere almacenar el seniority y el lenguaje de programación. 
// Para los testers se debe registrar la cantidad de proyectos asignados y el tipo de test que realiza (manual o automático).
// Se requiere: Definir las clases necesarias para llevar a cabo la administración de los desarrolladores y testers. 
// Incluir los métodos constructores de cada clase y definir un método que devuelva el valor de cada integrante.
// El siguiente programa debería funcionar correctamente con las clases definidas.

using System;

class Program {
  abstract class Aplicacion
  {
    protected Empleado[] empleados;

    protected Aplicacion(Empleado[] empleados)
    {
      this.empleados = empleados;
    }

    abstract public void setEmpleado(Empleado[] empleados);
    public Empleado[] getEmpleados()
    {
      return empleados;
    }
  }

  public class Empleado
  {
    protected string firstName, lastName;
    protected int age;
    protected Rol rol; 

    public Empleado(string firstName, string lastName, int age, Rol rol)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.age = age;
      this.rol = rol;
    }

    // public override void setEmpleado()
    // {

    // }
    public Rol getRol()
    {
      return rol;
    }
    private void setAge()
    {
      string input;
      int inputValue;
      bool isNumber;

      do
      {
        Console.Write("Ingrese su edad: ");
        input = Console.ReadLine().Trim();

        isNumber = int.TryParse(input, out inputValue);

        if (string.IsNullOrWhiteSpace(input) || !isNumber || inputValue < 0)
        {
          Console.Write("Porfavor ingrese correctamente su edad.");
          Console.WriteLine("");
        } else 
        {
          this.age = inputValue;
        }
      } while (string.IsNullOrWhiteSpace(input) || !isNumber || inputValue < 0);
    }
    public int getAge()
    {
      return age;
    }
    private void setLastName()
    {
      string input;
      bool isNumber;

      do
      {
        Console.Write("Ingrese su apellido: ");
        input = Console.ReadLine().Trim().ToLower();
        
        isNumber = int.TryParse(input, out _);

        if (isNumber || string.IsNullOrWhiteSpace(input))
        {
          Console.WriteLine("Porfavor ingrese su apellido correctamente.");
          Console.WriteLine("");
        }
      } while(isNumber || string.IsNullOrWhiteSpace(input));
    }
    public string getLastName()
    {
      return lastName;
    }
    private void setFirstName()
    {
      string input;
      bool isNumber;

      do
      {
        Console.Write("Ingrese su nombre: ");
        input = Console.ReadLine().Trim().ToLower();
        
        isNumber = int.TryParse(input, out _);

        if (isNumber || string.IsNullOrWhiteSpace(input))
        {
          Console.WriteLine("Porfavor ingrese su nombre correctamente.");
          Console.WriteLine("");
        }
      } while(isNumber || string.IsNullOrWhiteSpace(input));
    }
    public string getFirstName()
    {
      return firstName;
    }
  }

  public class Rol
  {
    protected string nameRol;

    public Rol(string nameRol) 
    {
      this.nameRol = nameRol;
    }

    private void setRol()
    {
      string input;
      bool isNumber;

      do
      {
        Console.WriteLine("Ingrese su rol (tester / desarrollador): ");
        input = Console.ReadLine().Trim().ToLower();

        isNumber = int.TryParse(input, out _);

        if (isNumber || string.IsNullOrWhiteSpace(input) || (input != "tester" && input != "desarrollador"))
        {
          Console.WriteLine("Porfavor ingrese su rol correctamente (tester / desarrolador).");
          Console.Write("");
        }
      } while (isNumber || string.IsNullOrWhiteSpace(input) || (input != "tester" && input != "desarrollador"));
    }
    public string getRol()
    {
      return nameRol;
    }
  }

  public class Desarrollador : Rol
  {
    protected string seniority, lenguaje;

    public Desarrollador(string seniority, string lenguaje) : base("Desarrollador")
    {
      this.seniority = seniority;
      this.lenguaje = lenguaje;
    }

    private void setLenguaje()
    {
      string input;
      bool isNumber;

      do
      {
        Console.Write("Ingrese su lenguaje favorito: ");
        input = Console.ReadLine().Trim().ToLower();
        
        isNumber = int.TryParse(input, out _);

        if (isNumber || string.IsNullOrWhiteSpace(input))
        {
          Console.WriteLine("Porfavor correctamente su lenguaje favorito.");
          Console.WriteLine("");
        }
      } while(isNumber || string.IsNullOrWhiteSpace(input));
    }
    public string getLenguaje()
    {
      return lenguaje;
    }
    private void setSeniority()
    {
      string input;
      bool isNumber;

      do
      {
        Console.Write("Ingrese su seniority: ");
        input = Console.ReadLine().Trim().ToLower();
        
        isNumber = int.TryParse(input, out _);

        if (isNumber || string.IsNullOrWhiteSpace(input) || (input != "trainee" && input != "junior" && input != "semi-senior" && input != "senior"))
        {
          Console.WriteLine("Porfavor ingrese correctamente su seniority (trainee, junior, semi-senior, senior).");
          Console.WriteLine("");
        } else 
        {
          this.seniority = input;
        }
      } while(isNumber || string.IsNullOrWhiteSpace(input) || (input != "trainee" && input != "junior" && input != "semi-senior" && input != "senior"));
    }
    public string getSeniority()
    {
      return seniority;
    }
  }

  public class Tester : Rol
  {
    protected string tipoTest;
    protected int cantProyect;

    public Tester(string tipoTest, int cantProyect) : base("Tester")
    {
      this.tipoTest = tipoTest;
      this.cantProyect = cantProyect;
    }

    private void setCantProyect()
    {
      string input;
      int inputValue;
      bool isNumber;

      do
      {
        Console.Write("Ingrese la cantidad de proyectos realizados: ");
        input = Console.ReadLine().Trim();

        isNumber = int.TryParse(input, out inputValue);

        if (string.IsNullOrWhiteSpace(input) || !isNumber || inputValue < 0)
        {
          Console.Write("Porfavor ingrese valores mayores a cero, de forma numérica.");
          Console.WriteLine("");
        } else 
        {
          this.cantProyect = inputValue;
        }
      } while (string.IsNullOrWhiteSpace(input) || !isNumber || inputValue < 0);
    }
    public int getCantProyect()
    {
      return cantProyect;
    }
    private void setTipoTest()
    {
      string input;
      bool isNumber;

      do
      {
        Console.Write("Ingrese el método utilizado para testear (manual / automatico): ");
        input = Console.ReadLine().Trim().ToLower();
        
        isNumber = int.TryParse(input, out _);

        if (isNumber || string.IsNullOrWhiteSpace(input) || (input != "manual" && input != "automatico"))
        {
          Console.WriteLine("Porfavor ingrese un valor correcto (manual / automatico).");
          Console.WriteLine("");
        } else 
        {
          this.tipoTest = input;
        }
      } while(isNumber || string.IsNullOrWhiteSpace(input) || (input != "manual" && input != "automatico"));
    }
    public string getTipoTest()
    {
      return tipoTest;
    }
  }
  static void Main(string[] args)
  {
    Console.WriteLine("Empleado 1");
    Desarrollador rol1 = new Desarrollador("Senior", "Java");
    Empleado dev1 = new Empleado("Tommi", "Perez", 21, rol1);
    Console.WriteLine($"Rol de {dev1.getFirstName()} {dev1.getLastName()}: " + rol1.getRol());

    Console.WriteLine("");

    Console.WriteLine("Empleado 2");
    Desarrollador rol2 = new Desarrollador("Senior", "Angular");
    Empleado dev2 = new Empleado("Cinthia", "Sanchez", 19, rol2);
    Console.WriteLine($"Edad de {dev2.getFirstName()} {dev2.getLastName()}: " + dev2.getAge() + " años");

    Console.WriteLine("");

    Console.WriteLine("Empleado 3");
    Tester rol3 = new Tester("Manual", 7);
    Empleado test1 = new Empleado("Walter", "Lopez", 25, rol3);
    Console.WriteLine($"Edad de {test1.getFirstName()} {test1.getLastName()}: " + test1.getAge() + " años"); 

    Console.WriteLine("");

    Console.WriteLine("Empleado 4");
    Tester rol4 = new Tester("Automatico", 8);
    Empleado test2 = new Empleado("Ezequiel", "Gomez", 25, rol4);
    Console.WriteLine($"Rol de {test2.getFirstName()} {test2.getLastName()}: " + rol4.getRol());
  }
}