using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Zoo
{
    public class GameManager : MonoBehaviour
    {
        public List<Animal> animals = new List<Animal>();

        public void EatLeaves()
        {
            foreach (Animal animal in animals){
                if (animal.diet == Diet.Herbivore || animal.diet == Diet.Omnivore)
                {
                    //Activate text
                    animal.TextBubble(animal.leavesReaction);
                }
            }
        }
    }
}

