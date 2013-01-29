using System.Collections.Generic;

namespace AdapterPattern
{
    public class Addopter:IClient
    {
        public string ReturnOddNumbers(List<int> numbers)
        {
            bool printoddNumber;
            string adad = string.Empty;
            var library = new library();
            foreach (var i in numbers)
            {
                printoddNumber = library.checkOdd(i);
                if (printoddNumber == true)
                {
                    adad = adad + i.ToString() + ",";
                }
            }

            return adad;   
        }
    }
}