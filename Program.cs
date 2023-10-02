namespace AssignmentNlog
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Sum sm = new Sum();
            //sm.Add(5, 4);


            //CRUD operations for arraylist
            //List<string> fruits = new List<string>();

            //create
            //fruits.Add("Apple");
            //fruits.Add("Banana");
            //fruits.Add("Cherry");

            //Console.WriteLine(string.Join(", ", fruits)); 

            //read
            //string firstFruit = fruits[0]; 
            //Console.WriteLine("First fruit: " + firstFruit);

            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit); 
            //}


            //update
            //fruits[1] = "Grapes"; 
            //Console.WriteLine(string.Join(", ", fruits)); 

            //delete
            //fruits.Remove("Cherry"); 
            //Console.WriteLine(string.Join(", ", fruits)); 

            //fruits.RemoveAt(0); 
            //Console.WriteLine(string.Join(", ", fruits)); 



            //CRUD operations for dictionary
           
            //create
            Dictionary<string, int> ages = new Dictionary<string, int>();

            ages.Add("Alice", 30);
            ages["Bob"] = 25;

            Console.WriteLine("Ages: ");
            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            //read
            int aliceAge = ages["Alice"];
            Console.WriteLine("Alice's age: " + aliceAge);


            //update
            ages["Alice"] = 31; 
            Console.WriteLine("Updated ages: ");
            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }


            //delete
            ages.Remove("Bob"); 
            Console.WriteLine("Remaining ages: ");
            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}