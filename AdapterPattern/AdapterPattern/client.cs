using System;
using System.Collections.Generic;

namespace AdapterPattern
{
    public interface IClient
    {
        string ReturnOddNumbers(List<int> numbers);
    }


    public class Client 
    {
        private readonly IClient _client;

        public Client(IClient client)
        {
            _client = client;
        }

        public string ReturnOddNumbers(List<int> numbers)
       {
           return _client.ReturnOddNumbers(numbers);
       }
       
      public static void Main()
      {
          var list=new List<int>();
          list.Add(1);
          list.Add(2);
          list.Add(3);
          Client client =new Client(new Addopter());
          var oddNumbers = client.ReturnOddNumbers(list);
          Console.WriteLine(oddNumbers);
      }
    }
    
}
