﻿using System;

namespace AbstractVirtual.Model {
    public abstract class Animal {

        public string Species { get; set; }
        public string Breed { get; set; }

        protected Animal(string species, string breed) {
            Species = species;
            Breed = breed;
        }

        /// <summary>
        /// Makes the animal perform a trick
        /// </summary>
        public abstract void PerformTrick();

        public virtual void FeedAnimal() {
            Console.Write("Yum ");
        }

        public override string ToString() => $"{Species} - {Breed}";
    }
}
