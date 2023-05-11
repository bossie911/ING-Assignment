using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Animal : MonoBehaviour
    {
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;


        public Image image;

        public AnimalData animalData;
        public string animalName;
        public bool canDoTrick;
        public Diet diet;
        public string leavesReaction;

        // Start is called before the first frame update
        void Start()
        {
            image.sprite = animalData.artwork;
            diet = animalData.diet;

            animalName = animalData.animalName;
            leavesReaction = animalData.leavesReaction;
        }

        public void TextBubble(string text)
        {
            Balloon.SetActive(true);
            text = leavesReaction;
        }

    }
}
