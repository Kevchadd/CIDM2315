namespace Lecture8;
class Program
{
    static void Main(string[] args)
    {
       Customer alice = new Customer(id : 110, name: "Alice" , age: 28);
       Customer Bob = new Customer(id :111, name: "Bob", age: 30);
       alice.printCusinfo();
       Bob.printCusinfo();
       alice.ChangeID(220);
       Bob.ChangeID(221);
       alice.printCusinfo();
       Bob.printCusinfo();

       alice.CompareAge(Bob);
    }

}
class Customer{

private int cus_id;

public string cus_name;
public int cus_age;
public Customer(int id, string name, int age){
cus_id = id;
cus_name=name;
cus_age=age;}


public void ChangeID(int new_id){
    cus_id = new_id;
}

public void printCusinfo(){Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age} ");
}



public void CompareAge(Customer objCustomer){
   
    if (this.cus_age >= objCustomer.cus_age){Console.WriteLine($"{this.cus_name}  is older");}
    else {Console.WriteLine ($"{objCustomer.cus_name} is older");}
    }

}





