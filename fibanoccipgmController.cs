using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fibpgm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class fibanoccipgmController : ControllerBase
    {
        // GET: api/fibanoccipgm
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/fibanoccipgm/5
        [HttpGet("{id}", Name = "Get")]
        public int Get(int id)
        {
            int n1 = 0, n2 = 1, n3=0, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            return n3;
        }

        // POST: api/fibanoccipgm
        [HttpPost]
        public int post(int id)
        {

            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
            return true;
        }

    }
}
            

        // PUT: api/fibanoccipgm/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
