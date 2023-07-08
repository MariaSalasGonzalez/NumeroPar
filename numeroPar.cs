using System;
namespace numPar{
    public class numero {
        //Variables
        string num;
        int n = 0;
        double resultado = 0;
            public void numeroPar() {
            Console.Write("Digite un numero entero -> ");
            num = Console.ReadLine();
            n = int.Parse(num);
            resultado = n % 2;
                if (resultado==0){
                Console.WriteLine("El numero digitado es entero!");
                } else{
                Console.WriteLine("El numero digitado es impar!");
                }

      }//fin metodo 
    }//fin clase
}//fin namespace