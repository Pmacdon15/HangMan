using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    internal class WordClass
    {

        private string[] words = [
    "Class",
    "Object",
    //"Inheritance",
    //"Polymorphism",
    "Encapsulation",
    //"Abstraction",
    //"Method",
    //"Attribute",
    //"Constructor",
    //"Destructor",
    //"Interface",
    //"Overloading",
    //"Overriding",
    //"Static",
    //"Dynamic",
    //"Instance",
    //"Prototype",
    //"Aggregation",
    //"Composition",
    //"Association"
  ];

        public WordClass() { }
        public string getRandomWord()
        {

            Random rnd = new Random();
            int index = rnd.Next(words.Count());
            return words[index].ToUpper();
        }
    }
}
