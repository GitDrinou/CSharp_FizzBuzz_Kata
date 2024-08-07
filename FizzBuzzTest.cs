using System.ComponentModel.Design;
using System.Runtime.InteropServices.JavaScript;
using NFluent;
using NUnit.Framework;
namespace Kata_FizzBuzz;

public class FizzBuzzTest{
        [Test]
        public void ShouldReturn1WhenGivenNumber1()
        {
            var fizzBuzz = new FizzBuzz();
            var actual = fizzBuzz.Generate(1);
            Check.That(actual).IsEqualTo("1");
        }

        [Test]
        public void ShouldReturn2WhenGivenNumber2()
        {
            var fizzBuzz = new FizzBuzz();
            var actual = fizzBuzz.Generate(2);
            Check.That(actual).IsEqualTo("2");
        }
        
        
        
        public class FizzBuzz
         {
             public string Generate(int number)
             {
                 return number.ToString();
             }
         }
}


