namespace EspacioEmpresa;
/* Auxiliar;
; Ingeniero; Especialista; Investigador.*/
public enum Cargo {
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
   
 private string Nombre = " ";
 private string apellido = " ";
 private DateTime fechaNac;
  private char estadoCivil;
   private char genero;
 private DateTime fechaIngreso;
 private double sueldoBasico;
 private Cargo cargo;

    public string Nombre1 { get => Nombre; set => Nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargo Cargo { get => cargo; set => cargo = value; } 

//      Calcular lo siguiente:
// i. La antigüedad del empleado en la empresa.
// ii. La edad del empleado,
// iii. La cantidad de años que le falta al empleado para poder
// jubilarse (para la mujer la edad es 60 años, para el varón es 65
// años).

public int antiguedad( DateTime fechaIngreso){
    DateTime hoy = DateTime.Now;
    int anios = 0; 
    anios = fechaIngreso.Year - hoy.Year; 
    if( anios != 0){
        if (fechaIngreso.Month >= hoy.Month && fechaIngreso.Day >= hoy.Day  )
        {

            return anios;
            
        }else
        {
            anios = anios -1; 
        }

    }  
        return anios;
   
}

public int aniosParaJub( int edad, char genero){
   int aniosJub = 0; 
    if (genero == 'm')
    {
        aniosJub = 60 - edad;
        
    } else if (genero == 'f' )
    {
         aniosJub = 65 - edad;
        
    }

    return aniosJub;
}
 public double calcularSalario( int antiguedad, Cargo cargo, char estadoCivil, double sueldoBasico){
    

    if (antiguedad >0)
    {
          sueldoBasico *= (antiguedad/100 +1);
        
    }
    if (cargo == Cargo.Ingeniero || cargo == Cargo.Especialista )
    {
        sueldoBasico *=1.50;
        
    }
    if (estadoCivil == 'c')
    {
        sueldoBasico+=15000;
        
    }

    return sueldoBasico; 


 }

}