﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class GameManager : MonoBehaviour
    {
        public List<Animal> animals = new List<Animal>();

        [SerializeField] private InputField inputField;

        public void GiveLeaves()
        {
            foreach (Animal animal in animals){
                if (animal.animalData.diet == Diet.Herbivore || animal.animalData.diet == Diet.Omnivore)
                {
                    //Activate text
                    animal.TextBubble(animal.animalData.leavesReaction);
                }
            }
        }

        public void GiveMeat()
        {
            foreach (Animal animal in animals)
            {
                if (animal.animalData.diet == Diet.Carnivore || animal.animalData.diet == Diet.Omnivore)
                {
                    //Activate text
                    animal.TextBubble(animal.animalData.meatReaction);
                }
            }
        }

        public void DoTrick()
        {
            foreach (Animal animal in animals)
            {
                if (animal.animalData.canDoTrick == true)
                {
                    //Do a trick
                    StartCoroutine(animal.DoTrick());
                }
            }
        }

        public void Hello()
        {
            if (inputField.text == "")
            {
                foreach (Animal animal in animals)
                {
                    animal.TextBubble(animal.animalData.helloReaction);
                }
            }
            else
            {
                foreach (Animal animal in animals)
                {
                    if(animal.animalData.animalName == inputField.text)
                    {
                        animal.TextBubble(animal.animalData.helloReaction);
                    }
                }
            }
        }
    }
}

