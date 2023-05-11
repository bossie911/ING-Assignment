using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField] private GameManager gameManager;


        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra;

        //public List<Animal> animals = new List<Animal>();
        private void Start()
        {
            //Lion
            Animal henk = Instantiate(lion, transform).GetComponent<Animal>();
            gameManager.animals.Add(henk);
            //Hippo
            Animal elsa = Instantiate(hippo, transform).GetComponent<Animal>();
            gameManager.animals.Add(elsa);
            //Pig
            Animal dora = Instantiate(pig, transform).GetComponent<Animal>();
            gameManager.animals.Add(dora);
            //Tiger
            Animal wally = Instantiate(tiger, transform).GetComponent<Animal>();
            gameManager.animals.Add(wally);
            //Zebra
            Animal marty = Instantiate(zebra, transform).GetComponent<Animal>();
            gameManager.animals.Add(marty);         
        }
    }
}
