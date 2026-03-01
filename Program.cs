
#region Part 1

// #region Problem 1


// // public class BanckAccount
// // {
//     // public string Owner;
//     // public double Balance;
//     // public void withdraw(double amunt)
//     // {
//     //     Balance -= amunt;
//     // }

// // Identify at least two problems with this design from an encapsulation perspective

// // 1- the fields are public, this means that any code can access and ,modify the balance and owner
// // 2- the withdraw method does't have any validation 

// // To Solve These Problems , we can make The Fields Private 

// // private string Owner;
// // private double Balance;

// // public void withdraw(double amount)
// //     {
// //         if( amount >Balance){
// //             Console.WriteLine("Insufficient Funds");
// //         }
// //         else{
// //             Balance -= amount;
// //         }
// //     }

// // }


//     //Explain why exposing fields directly (as public) is considered a bad practice in OOP.
//     //because it breaks Encapulation, it allows any code to access and modify the fields without any control or vaildation
// #endregion

// #region Problem 2
//     //  What is the difference between a field and a property in C#? Can a property contain logic? Give an example of a read-only property that returns a calculated value.


//     //A -Field Stores data directly, Dosn't have any Logic ,Usually private,
//     //A -Property Provides a way to access and modify the data, Can contain logic, Usually public


//     // example of a read-only property that returns a calculated value
//     // public class Circle
// {
//     // private double radious;

//     // public Circle(double ra)
//     // {
//     //     radious = ra;
//     // }
//     // public double Area
//     // {
//     //     get
//     //     {
//     //         return 3.14 * radious * radious;
//     //     }
//     // }


//     // public double r {get;}
//     // public Circle(double r)
//     // {
//     //     this.r = r;
//     // }

//     // public double Area => 3.14 * r * r;
// } 
// #endregion


#region Problem 3



public class Register 
{
    // private string[]names = new string[5];

    // public string this[int index]
    // {
    //     get { return names[index]; }
    //     set { names[index] = value; }
    // }
    //a) What is `this[int index]` called? Explain its purpose.
    // A- this is an indexer,  it allows an object to be indexed like an array


    //What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer safer?

    // it will throw an Exception because the index is out of range,To make the indexer safer we can add a validation to check if the index is within the bounds of the array before accessing it



    // private string[] names = new string[5];

    // public string this[int index]
    // {
    //     get
    //     {
    //         if (index >= 0 && index < names.Length)
    //         {
    //             return names[index];
    //         }
    //         else
    //         {
    //             throw new IndexOutOfRangeException("Index is out of range");
    //         }
    //     }
    //     set
    //     {
    //         if (index >= 0 && index < names.Length)
    //         {
    //             names[index] = value;
    //         }
    //         else
    //         {
    //             throw new IndexOutOfRangeException("Index is out of range");
    //         }
    //     }
    // }



    //Can a class have more than one indexer? If yes, give an example of when that would be useful.

    //Yes, a class can have more than one indexer. For example, a class representing a matrix might have two indexers: one for row and column indices, 
    // and another for a single index that traverses the matrix in row-major order.





}

public class Program
{
    public static void Main()
    {
        StudentRegister register= new();

       register.AddStudent(new Student ( "Alice", 1 ));
       register.AddStudent(new Student ( "Bob", 2 ));
       register.AddStudent(new Student ( "Charlie", 3 ));

       System.Console.WriteLine(register[0].Name); // Output: Alice

         System.Console.WriteLine(register["Bob"].Id); // Output: 2
    }
}

#endregion


#endregion

