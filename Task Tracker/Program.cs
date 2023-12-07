// Task Manager

// Bool for loop control
bool doAgain = true;

List<string> taskList = new List<string>();

// Loop through until user makes a choice
while (doAgain)
{
   DisplayOptions();

   string userChoice = Console.ReadLine();

   switch (userChoice)
   {
      case "1":
         Console.WriteLine("\nAdding Task");
         AddTask();
         break;
      case "2":
         Console.WriteLine("\nViewing Task");
         ViewTask();
         break;
      case "3":
         Console.WriteLine("\nRemoving Task");
         break;
      case "4":
         Console.WriteLine("\nSee Yah");
         doAgain = false;
         break;
      default:
         Console.WriteLine("Invalid choice please select an option\n");
         break;
   }
}








// -----------------------------------------------------------Methods------------------------------------------------------------------

// Display Options Method
static void DisplayOptions()
{
   Console.WriteLine("Welcome to Task Manager!");

   Console.WriteLine("\nPlease select an option.");
   Console.WriteLine("1. Add Task");
   Console.WriteLine("2. View Task");
   Console.WriteLine("3. Remove Task");
   Console.WriteLine("4. Exit");
}

// Adding Task Method
void AddTask()
{
   Console.Clear();
   Console.WriteLine("Please enter the task description.");
   string newTask = Console.ReadLine();

   Console.WriteLine("Are you sure you want to save this task enter yes(y) or no(n)?");
   string choice = Console.ReadLine().ToLower();
   if (choice == "y" || choice == "yes")
   {
      taskList.Add(newTask);
      Console.WriteLine("Task added!\n");
   }
   else
   {
      // Go to options
      Console.WriteLine("Task not created.\n");
   }

}

// View Task Method
void ViewTask()
{
   foreach(string task in taskList)
   {
      Console.Write(taskList.IndexOf(task) + 1 + ". ");
      Console.WriteLine("" + task);
   }

   Console.WriteLine("\n");
}

// Remove Task Method
// void RemoveTask()
// {
//    ViewTask();

//    Console.WriteLine("Enter the number of the task youu wish to remove");
//    string deleteTask = Console.ReadLine();

//    int taskNumber = Convert.ToInt32(deleteTask) - 1;

//    if (taskNumber = taskList[taskNumber])
//    {
//       taskList.Remove(taskNumber);
//    }
// }