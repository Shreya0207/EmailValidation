using System;


namespace EmailValidation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pin = new Pattern();
            bool validResult = pin.ValidateEmail("abc@yahoo.com.com");
           Console.WriteLine("Email validation:"+" "+validResult);
        }
    }
}
