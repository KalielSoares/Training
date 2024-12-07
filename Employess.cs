namespace Treinamento {
    public class Employee {

        private int Id { get; set; }
        private string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id,string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }


        public double SALARY => Salary;
        public int ID => Id;

        public override string ToString() {
            return Id + ", "  + Name + ", " + Salary;
        }
    }
}
