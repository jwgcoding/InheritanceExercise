using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();

            myBird.Wings = 2;
            myBird.Beak = 1;
            myBird.Talons = 12;
            myBird.Feathers = 300;

            var lizard = new Reptile()
            {

                Claws = 16,
                Scales = 12131,
                Markings = true,
                HasTail = true,
            };

            Console.WriteLine($" My bird has {myBird.Wings} wings, {myBird.Beak} beak, {myBird.Talons} talons, {myBird.Feathers} feathers.");


            Console.WriteLine($" My lizard has {lizard.Claws} claws, {lizard.Scales} scales." + " " + $"My lizard also has markings, {lizard.Markings} and a tail, {lizard.HasTail}.");


        }
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
               * Creatively display the class member values 
             */
           
        }

    }
    

