#region ""

using System;





namespace LS_6_Arrays
{
    class Program
    {

        #endregion
        /*
            Welcome to lesson 6 Arrays!

            Arrays allow for a variable to hold more than one of the same datatype.
            
            Any datatype can use arrays (ints,floats,strings).

            An example of an array declaration is:

            int [] my_int_array = {0,1,2};

            there are three values in the array and to access each one you list the position the value is stored in i.e

            my_int_array[0] would be value 0

            my_int_array[1] would be value 1

            my_int_array[2] would be value 2

            Arrays Start counting their first position at 0.

            
            
         */

        static void Main(string[] args)
        {
            

           

            int [] my_int_array = {0,1,1,2,3,5,8,13};

            int my_array_length = my_int_array.Length;

            var my_int = 0;

            Console.Write("my_int_array holds: {");

            for (var i = 0; i < my_array_length; i++)
            {
                if (i > 0)
                {
                    Console.Write(",");
                }               

                my_int = my_int_array[i];

                Console.Write(my_int.ToString());
            }

            Console.WriteLine("}\n");


            Console.WriteLine("This is how to write a single element: "+ my_int_array[0].ToString());


        }
        #region ""
    }
}
#endregion