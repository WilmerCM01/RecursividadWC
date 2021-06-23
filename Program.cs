using System;

namespace RecursividadWC
{
    class Program
    {

		static int Suma_I(int numero){
			
			int suma = 0;
			int resultado = 0;
			
			while(suma <= numero){
				
				resultado+=suma;
				suma+=1;
				
			}
			
			return resultado;
			
		}
		
		static int Factorial_I(int numero){
			
			int factor = 1;
			int resultado = 1;
			
			while(factor <= numero){
				
				resultado*=factor;
				factor+=1;
				
			}
			
			return resultado;
			
		}
		
		static int MCD_I(int numero1, int numero2){
			
			int modulo = 1;
			
			while(modulo != 0){
				
				modulo = numero1 % numero2;
				numero1 = numero2;
				
				if(modulo != 0){
					
					numero2 = modulo;
					
				}
				
			}
			
			return numero2;
			
		}
		
		static int Suma_R(int numero){
			
			if(numero == 1){
				
				return 1;
				
			}else{
				
				return numero + Suma_R(numero-1);
				
			}
			
		}
		
		static int Factorial_R(int numero){
			
			if(numero == 1){
				
				return 1;
				
			}else{
				
				return numero * Factorial_R(numero-1);
				
			}
			
		}
		
		static int MCD_R(int numero1, int numero2){
			
			if(numero2 == 0){
				
				return numero1;
				
			}else{
				
				return MCD_R(numero2, numero1 % numero2);
				
			}
			
		}

        static void Main(string[] args)
        {

			Console.WriteLine();
			
			Console.Write("Sumatoria: ");
			int sumatoria = int.Parse(Console.ReadLine());
			
			Console.Write("Factorial: ");
			int factor = int.Parse(Console.ReadLine());
			
			Console.WriteLine();
			Console.WriteLine("Máximo Común Divisor");
			Console.WriteLine();
			Console.Write("Primer número: ");
			int mcd1 = int.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.Write("Segundo número: ");
			int mcd2 = int.Parse(Console.ReadLine());
			
			Console.WriteLine();
			
			Console.WriteLine(new String('-', 50).ToString());
			Console.WriteLine("Iteración");
			Console.WriteLine();
			
			Console.WriteLine("Sumatoria: " + Suma_I(sumatoria));
			Console.WriteLine("Factorial: " + Factorial_I(factor));
			Console.WriteLine("MCD: " + MCD_I(mcd1, mcd2));
			
			Console.WriteLine();
			
			Console.WriteLine(new String('-', 50).ToString());
			Console.WriteLine("Recursión");
			Console.WriteLine();
			
			Console.WriteLine("Sumatoria: " + Suma_R(sumatoria));
			Console.WriteLine("Factorial: " + Factorial_R(factor));
			Console.WriteLine("MCD: " + MCD_R(mcd1, mcd2));
			
			Console.WriteLine("");
			Console.WriteLine("Presione cualquier tecla para finalizar...");
			Console.ReadKey();

        }
    }
}