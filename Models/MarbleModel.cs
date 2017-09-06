using System;
using System.Collections.Generic;

namespace Marbles.Models
{
    public class MarbleModel
    {
        public int ID { get; set; }
        public string Color { get; set; }
        private static string[] colors { get; set; } = { "Green", "Blue", "Orange", "Red", "Black", "White" };

        public MarbleModel()
        {
            var r = new Random();
            Color = colors[r.Next(1, 6)];

        }

        public override string ToString()
        {
            return $"Marble: {ID} is of the color {Color}";
        }
    }
}
