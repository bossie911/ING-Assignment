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
        private Text textField;

        public string animalName;
        public Image image;
        public AnimalData animalData;

        // Start is called before the first frame update
        void Start()
        {
            image.sprite = animalData.artwork;
        }

        public void TextBubble(string text)
        {
            Balloon.SetActive(true);
            textField.text = text;
        }
    }
}
