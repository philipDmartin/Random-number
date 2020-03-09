using System;
using System.Collections.Generic;

namespace randomNumber {
    class Program {
        static void Main (string[] args) {
            Random rand = new Random ();
            List<int> numbers = new List<int> {
                rand.Next (0),
                rand.Next (1),
                rand.Next (2),
                rand.Next (3),
                rand.Next (4),
                rand.Next (5),
            };

            for (int i = 0; i < numbers.Count; i++) {
                if (numbers.Contains (i)) {
                    Console.WriteLine ($"Number list contains{i}");
                } else {
                    Console.WriteLine ($"Number list does not contain{i}");
                }
            }
        }
    }
}