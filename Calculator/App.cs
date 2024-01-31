namespace Calculator;

public class App
{
    public void Run() {
        while (true) {
            int a = ReadInt("Indtast første tal:");
            var ch = Console.ReadKey().KeyChar;
            if (ch != '+')
            {
                Console.WriteLine("Kun + som operator virker");
                continue;
            }
            Console.WriteLine();
            int b = ReadInt("Indtast andet tal:");
            Console.WriteLine($"Resultat = {a+b}");
        }
    }

    int ReadInt(string leadingText) {
        Console.Write(leadingText);
        return Convert.ToInt32(Console.ReadLine());
    }
}