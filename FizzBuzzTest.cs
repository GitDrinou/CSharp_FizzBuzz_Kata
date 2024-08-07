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

        [Test]
        public void ShouldReturnFizzWhenGivenNumberIsDivisibleBy3()
        {
            var fizzbuzz = new FizzBuzz();
            var actual = fizzbuzz.Generate(9);
            Check.That(actual).IsEqualTo("Fizz");
        }

        [Test]
        public void ShouldReturnBuzzWhenGivenNumberIsDivisibleBy5()
        {
            var fizzbuzz = new FizzBuzz();
            var actual = fizzbuzz.Generate(25);
            Check.That(actual).IsEqualTo("Buzz");
        }

        [Test]
        public void ShouldReturnFizzBuzzWhenGivenNumberIsDivisibleBy3And5()
        {
            var fizzbuzz = new FizzBuzz();
            var actual = fizzbuzz.Generate(15);
            Check.That(actual).IsEqualTo("FizzBuzz");
        }
        
        
        public class FizzBuzz
         {
             public string Generate(int number)
             {
                 var value = "";
                     
                 if (number % 3 == 0)
                 {
                     value = "Fizz";
                 }

                 if (number % 5 == 0)
                 {
                     value += "Buzz";
                 }

                 return string.IsNullOrEmpty(value) ? number.ToString() : value;
             }
         }
}


