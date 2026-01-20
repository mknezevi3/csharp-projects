
using System.Diagnostics.Tracing;

List<string> toDo = new List<string>();

string userInput;


static void addToDo(List<string> toDo)
{

    string description;

    Console.WriteLine("Enter your description");

do
{
    
        do
        {
            description = Console.ReadLine();
            if (toDo.Contains(description)
                { 
            Console.WriteLine("Description must be unique!");
                }
        } while(toDo.Contains(description));



    if (string.IsNullOrWhiteSpace(description))
    {
        Console.WriteLine("Description can not be empty,try again.");
    }

} while (string.IsNullOrWhiteSpace(description));


toDo.Add(description);


}


static void seeToDos(List<string> toDo) 
{
    int i = 1;
    foreach (string ToDo in toDo) 
    {
        
        Console.WriteLine( i + "." + $"{ToDo}");
        i++;
    }
}










do
{
    Console.WriteLine("What do you want to do? \r\n[S]ee all todos\r\n[A]dd a todo\r\n[R]emove a todo\r\n[E]xit");


    do
    {
        userInput = Console.ReadLine();
        userInput = userInput.ToUpper();

        if (userInput != "S" && userInput != "A" && userInput != "R" && userInput != "E")
        {
            Console.WriteLine("Invalid choice");
        }

    } while (userInput != "S" && userInput != "A" && userInput != "R" && userInput != "E");

    switch (userInput) 
    {
        case "S":
            seeToDos(toDo);
            break;
        case "A":
            addToDo(toDo);
            break;
        case "R":
            
            break;
    }

    

} while (userInput != "E" && userInput != "e");






Console.ReadKey();
