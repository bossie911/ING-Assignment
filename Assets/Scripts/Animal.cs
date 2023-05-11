using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Animal : MonoBehaviour
    {
        public Image image;

        public AnimalData animalData;
        public string animalName;
        bool canDoTrick;
        Diet diet;

        // Start is called before the first frame update
        void Start()
        {
            image.sprite = animalData.artwork;

            animalName = animalData.animalName;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
