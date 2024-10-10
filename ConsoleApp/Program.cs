using Mylibrary;

Secretary Maria = new Secretary();
Maria.Name = "Maria";
Manager Pedro = new Manager();
Pedro.Name = "Pedro";
Developer Miguel = new Developer();
Console.WriteLine($"Dias: {Miguel.GetPaymentDays()}");

WriteEmployerInfo(Maria);
WriteEmployerInfo(Miguel);
WriteEmployerInfo(Pedro);

void WriteEmployerInfo(Employer employer)
{
    Console.WriteLine($"{employer.Name}: {employer.CalculateMonthlyPayment()}");
    Console.WriteLine($"Days: {employer.GetPaymentDays()}");
}