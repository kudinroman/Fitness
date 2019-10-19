using System;

namespace Fitness.BL.Model
{
    /// <summary>
    /// User
    /// </summary>
    class User
    {
        #region Properties
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gender
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Date of Birth
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Weight
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        public double Height { get; set; }
        #endregion

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="gender">Gender</param>
        /// <param name="birthDate">Date of birth</param>
        /// <param name="weight">Weight</param>
        /// <param name="height">Height</param>
        public User(string name,
            Gender gender,
            DateTime birthDate,
            double weight,
            double height)
        {
            #region Check input parameters
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("User name cannot be empty or null", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("User gender cannot or null", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentNullException("Impossible date of birth", nameof(birthDate));
            }

            if (weight <= 0)
            {
                throw new ArgumentNullException("Weight cannot be less than zero", nameof(weight));
            }

            if (height <= 0)
            {
                throw new ArgumentNullException("Height cannot be less than zero", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
