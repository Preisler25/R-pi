namespace Röpi;

class Program
{
    static string GetStr(){
        return Console.ReadLine();
    }

    static int GetInt(){
        return int.Parse(Console.ReadLine());
    }

    static void Print(string str){
        Console.WriteLine(str);
    }

    static void Wait(){
        Console.ReadKey();
    }

    static void callc(int num1, int num2, string op){
        switch (op)
        {
            case "+":
                Print("Az eredmény: " + (num1 + num2));
                break;
            case "-":
                Print("Az eredmény: " + (num1 - num2));
                break;
            case "*":
                Print("Az eredmény: " + (num1 * num2));
                break;
            case "/":
                Print("Az eredmény: " + (num1 / num2));
                break;
            default:
                Print("Hibás operátor!");
                break;
        }
    }

    static void Main(string[] args)
    {
        Elso();
        Masodik();
        Harmadik();
        Wait();
    }
    static void Elso(){
        int num;

        Print("Kérem a számot: ");
        num = GetInt();

        if (num < 0){
            Print("A szám negatív.");
        } else if (num > 0){
            Print("A szám pozitív.");
        } else {
            Print("A szám nulla.");
        }
    }

    static void Masodik(){
        int num1;
        int num2;
        string op;

        Print("Kérem az első számot: ");
        num1 = GetInt();

        Print("Kérem a második számot: ");
        num2 = GetInt();

        Print("Kérem az operátort: ");
        op = GetStr();

        callc(num1, num2, op);
    }

    static void Harmadik(){
        int evfolyam;
        int kor;

        Print("Kérem az évfolyamot: ");
        evfolyam = GetInt();

        Print("Kérem a kort: ");
        kor = GetInt();

        if (6 <= kor && kor <= 12 && 1 <= evfolyam && evfolyam <= 6){
            Print("Az iskolás korú diák");
        } else if (13 <= kor && kor <= 18 && 7 <= evfolyam && evfolyam <= 12){
            Print("Középiskolás diák.");
        } else if (kor < 0 || evfolyam < 0){
            Print("Eroor");
        }
        else {
            Print("Nem iskolás korú diák.");
        }
    }
}

