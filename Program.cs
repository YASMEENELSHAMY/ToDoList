using System.Numerics;

internal class program
{

    
    static void showToDos(List<string>l)
    {
        if (l.Count == 0)
        {
            Console.WriteLine("No TODOs have been added yet.");
            return;
        }
        int i = 1;
        foreach(string s in l)
        {

            Console.WriteLine($"{i}- {s}");
            i++;
        }

    }
    static void add( List<string> l) {
        Console.WriteLine("Enter the TODO description: ");
        string des = Console.ReadLine();
        while (true)
        {
            bool flag=true;
            foreach (string des2 in l)
            {
                if (des2.Equals(des))
                {
                    Console.WriteLine("The description must be unique.");
                    flag = false;
                    break;
                }

            }
            if (des.Length != 0 && flag)
            {
                l.Add(des);
                Console.WriteLine($"TODO successfully added: {des}");
                break;
            }

            else if (des.Length == 0)
            {
                Console.WriteLine("The description can not be empty.");

            }
         
            

        }
    }
    static void remove(List<string>l) {

        Console.WriteLine("Select the index of the TODO you want to remove: ");

        while (true)
        {
            string index = Console.ReadLine();

            if (string.IsNullOrEmpty(index))
            {
                Console.WriteLine("Selected index can not be empty.");
            }
            else
            {
              

                if ( !int.TryParse(index, out int i)|| int.Parse(index) > l.Count || int.Parse(index)<0)
                    Console.WriteLine("“The given index is not valid.");
                else
                {
                    int indx = int.Parse(index);
                    Console.WriteLine($"TODO removed:{l[indx-1]}");
                    l.Remove(l[indx-1]);
                    break;
                }

            }
            Console.WriteLine("Select the index of the TODO you want to remove: ");

        } 
    }
    static void Main(string[] args) {
        List<string> toDoList = new List<string>();


        
      
        while(true) {
            Console.WriteLine("Hello!");
            Console.WriteLine("Whatdoyouwanttodo?");
            Console.WriteLine("[S]eeallTODOs");
            Console.WriteLine("[A]ddaTODO");
            Console.WriteLine("[R]emoveaTODO");
            Console.WriteLine("[E]xit");

            string choice = Console.ReadLine();

            if (choice.ToLower() == "e")
                break;
            
            switch (choice.ToLower())
            {
                case "s":
                    showToDos(toDoList);
                    break;

                case "a":

                    add(toDoList);
                    break;

                case "r":
                    showToDos(toDoList);
                    if (toDoList.Count > 0)
                        remove(toDoList);
                    break;

                default:
                    Console.WriteLine("Incorrect input");
                    break;

  
            }


        }
    
    }

       
}