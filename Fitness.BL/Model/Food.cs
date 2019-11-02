using System;

namespace Fitness.BL.Model
{
    [Serializable]
    public class Food
    {
        public string Name { get; }
        public double Callories { get; }

        /// <summary>
        /// Proteins
        /// </summary>
        public double Proteins { get; }

        /// <summary>
        /// Fats
        /// </summary>
        public double Fats { get; }

        /// <summary>
        /// Carbohydrates
        /// </summary>
        public double Carbohydrates { get; }

        /// <summary>
        /// Calories per 100 grams of product
        /// </summary>
        public double Calories { get; }

        public Food(string name) : this(name, 0, 0, 0, 0) { }

        public Food(string name, double callories, double proteins, double fats, double carbohydates)
        {
            // TODO: проверка


            Name = name;
            Callories = callories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydates / 100.0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}