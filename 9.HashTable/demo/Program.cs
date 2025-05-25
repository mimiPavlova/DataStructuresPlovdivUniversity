using System.Collections;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Хеш таблиците съдържат ключ и стойност

            Hashtable  table = new Hashtable();
            table["name"]="Maria";
            table["age"]=19;
            Console.WriteLine(table["name"]);
            Console.WriteLine(table["age"]);


            //Как работи 
            //->когато добавиш ключ, той се хешира-чрез хешф,нкция се преобразува в число
            //->това число определя индекс в масив-там се пази стойността
            //->Ако два ключа имат еднакъв хеш (рядко), възниква колизия, но тя се обработва вътрешно.
            // Основни операции
            //->Insert-поставя двойка с ключ и стойност
            //->Search-намира стойност по даден ключ
            //->Remove-премахване на двойка по ключ
            //->Contains-проверка дали даден ключ съществува
        }
    }
}
