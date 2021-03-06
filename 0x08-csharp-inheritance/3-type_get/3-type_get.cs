using System;
using System.Reflection;


///<summary>Checks Obj</summary>
class Obj
{
    ///<summary>Prints object methods.</summary>
    public static void Print(object myObj)
    {
        TypeInfo objInformation = myObj.GetType().GetTypeInfo();

        Console.WriteLine($"{objInformation.Name} Properties:");

        foreach (PropertyInfo property in objInformation.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine($"{objInformation.Name} Methods:");

        foreach (MethodInfo method in objInformation.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
