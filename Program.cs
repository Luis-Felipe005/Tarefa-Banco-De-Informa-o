// See https://aka.ms/new-console-template for more information
using AtividadeContaBancária;

Console.WriteLine("Hello, World!");


Cliente cliente = new Cliente("Luis Felipe", "Luisaocunha@gmail.com", 3412, 2000.90, false, true);



Cliente cliente1 = new Cliente("Fernando", "FernandoLopes@gmail.com", 36438, 1500.00, true, true);

Cliente cliente2 = new Cliente("Lucas", "Lucasalves@gmail.com", 743923, 2850.99, false, true);


cliente.Mostra();
cliente.contaBancaria.Mostra();


cliente1.Mostra();
cliente1.contaBancaria.Mostra();

cliente2.Mostra();
cliente2.contaBancaria.Mostra();






