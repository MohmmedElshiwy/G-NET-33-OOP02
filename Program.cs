
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

#region Problem 2
    //  What is the difference between a field and a property in C#? Can a property contain logic? Give an example of a read-only property that returns a calculated value.


    //A -Field Stores data directly, Dosn't have any Logic ,Usually private,
    //A -Property Provides a way to access and modify the data, Can contain logic, Usually public


    // example of a read-only property that returns a calculated value
    // public class Circle
{
    // private double radious;

    // public Circle(double ra)
    // {
    //     radious = ra;
    // }
    // public double Area
    // {
    //     get
    //     {
    //         return 3.14 * radious * radious;
    //     }
    // }


    // public double r {get;}
    // public Circle(double r)
    // {
    //     this.r = r;
    // }

    // public double Area => 3.14 * r * r;
} 
#endregion

#endregion
