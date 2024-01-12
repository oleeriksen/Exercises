namespace Calculator;

public class App
{
    public void Run() {
        while (true) {
            int a = int.Parse(Console.ReadLine());
            var ch = Console.ReadKey().KeyChar;
            if (ch != '+')
            {
                Console.WriteLine("Kun + som operator virker");
                continue;
            }
            Console.WriteLine();
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultat = {a+b}");
        }



    }
}