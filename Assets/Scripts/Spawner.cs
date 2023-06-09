﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField] private GameManager gameManager;

        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra, wolf, elephant;

        private void Start()
        {
            //Lion
            SpawnAnimal(lion, "henk");

            //Hippo
            SpawnAnimal(hippo, "elsa");

            //Pig
            SpawnAnimal(pig, "dora");

            //Tiger
            SpawnAnimal(tiger, "wally");

            //Zebra
            SpawnAnimal(zebra, "marty");

            //Wolf
            SpawnAnimal(wolf, "max");

            //Elephant
            SpawnAnimal(elephant, "dombo");
        }

        //Function that spawns an animal and sets type and name
        private void SpawnAnimal(GameObject type, string animalName)
        {
            Animal animal = Instantiate(type, transform).GetComponent<Animal>();
            animal.animalName = animalName;
            gameManager.animals.Add(animal);
        }
    }
}
