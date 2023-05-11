﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public enum Diet
    {
        Carnivore,
        Herbivore,
        Omnivore
    }

    [CreateAssetMenu(fileName = "New Animal", menuName = "Animal")] 
    public class AnimalData : ScriptableObject
    {
        public string animalName;
        public Sprite artwork;
        public bool canDoTrick;
        public Diet diet;
        public string helloReaction;
    }
}