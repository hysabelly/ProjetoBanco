public class Conta
{

    //definindo propriedades
       public int Codigo {get;} 
       public double Saldo {get; private set;}
       public double destino {get; private set;}

    //definindo Conta
       public Conta (int codigo)
       {
               Codigo = codigo;
               Saldo = 0.0;
       }

    //operações da conta
       public void Sacar(double valor)
       {
        ValidarValor(valor);
        Saldo -= valor;
       }

        public void Depositar(double valor)
       {
        ValidarValor(valor);
        VerificarSaldo(Saldo);
        Saldo = Saldo + valor;
       }

    /*  public void transfere(double valor, Conta destino) 
        {
		    if (this.Saldo < valor) 
            {
                throw new ArgumentException("Saldo insuficiente.");
            } 
			this.Saldo -= valor;
			destino.Depositar(valor);

            Console.WriteLine(destino.Saldo);
            Console.WriteLine("Transferência bem sucedida!");   
		} 
	}*/

       public void Transferir(double valor, Conta destino) 
       {
        ValidarValor(valor);
        VerificarSaldo(Saldo);
		
	    Sacar(valor);
		destino.Depositar(valor);
        Console.WriteLine("Transferência bem sucedida! O saldo atual da sua conta é:");
		} 

        public void ValidarValor(double valor)
       {
          if(valor < 0) throw new ArgumentException("O valor deve ser maior que 0.");
       }

        public void VerificarSaldo(double valor)
       {
          if(valor > Saldo) throw new ArgumentException("Saldo insuficiente.");
       }
}
