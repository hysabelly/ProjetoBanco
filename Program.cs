﻿Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

c1.Depositar(1000.00);
Console.WriteLine(c1.Saldo);

c2.Depositar(200.0);
Console.WriteLine(c2.Saldo);

c1.Transferir(50.00, c2);
Console.WriteLine(c1.Saldo);
