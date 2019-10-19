﻿using System;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Gender
    /// </summary>
    class Gender
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Create new Gender
        /// </summary>
        /// <param name="name">Gender name</param>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Gender name cannot be empty or null");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
