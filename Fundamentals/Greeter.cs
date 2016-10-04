using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Greeter
    {
        private readonly string speaker;
        public string Speaker
        {
            get
            {
                Console.WriteLine("Returning Speaker=" + speaker);
                return speaker;
            }
            //private set
            //{
            //    speaker = value;
            //}
        }

        public Greeter(string speaker)
        {
            this.speaker = speaker;
        }

       
        public string SayHello(string recipient)
        {
            if(recipient == null)
            {
                throw new ArgumentNullException("recipient");
            }
            if(speaker == null)
            {
                return "Hello " + recipient;
            }
            return "Hello " + recipient + " from " + speaker;
        }
    }
}
