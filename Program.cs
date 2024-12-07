namespace Treinamento {
    public class Program {
        static void Main(string[] args) {
            List<Employee> employees = new List<Employee>();


            Console.WriteLine("How many employees will be registred?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Emplyoee #" + i);
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("Enter the employee id that have salary increase: ");
            int a = int.Parse(Console.ReadLine());

            Employee b = employees.Find(x => x.ID == a);
            
            if (b == null) {
                Console.WriteLine("This id does not exist");
            }

            Console.WriteLine("Enter the percentage");
            double percentage = double.Parse(Console.ReadLine());

            Employee s = employees.Find(x => x.ID == a);
            poe
            if (s != null)
            {
                s.Salary += s.Salary * (percentage / 100);
            }


            Console.WriteLine("Updated list of employees:");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

        }

    }
}
