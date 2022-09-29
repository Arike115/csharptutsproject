#define funkewashere
#undef funkegone
namespace csharptutsproject

{
    public class Program
    {

        /// <summary>
        /// Set-Operators
        ///     Distinct --->returns distinct values
        ///     union ---> union combines two collection into one collaction
        ///     intersect -----> returns the common elements between the two collection
        ///     except ----> returns the elements that are present in the first collection but not in the second 
        ///                 collection
        /// </summary>
        public static void Main()
        {
            string[] Countries = { "Nigeria", "India", "Uk", "Canada", "Japan", "Uk","uk" };
            int[] numbers = { 1, 2, 3, 4, 5};
            int[] word = { 5, 4, 7, 8, 9 };
            var result = Countries.Distinct(StringComparer.OrdinalIgnoreCase);
            var result2 = numbers.Distinct();

            var unionresult = numbers.Union(word);
            var intersectresult = numbers.Intersect(word);
            var unionexcept = numbers.Except(word);

            foreach (int results in unionexcept)
            {
                Console.WriteLine(results);
            }

            Console.WriteLine("----------------intersect-------"); 
            foreach (int results in intersectresult)
            {
                Console.WriteLine(results);
            }

            Console.WriteLine("----------------union-------");

            foreach(int results in unionresult)
            {
                Console.WriteLine(results);
            }

            //foreach(var country in result)
            //{
            //    Console.WriteLine(country);
            //}


            //foreach (var country in result2)
            //{
            //    Console.WriteLine(country);
            //}

            // Console.ReadKey();
        } 

        




    }
    

}

