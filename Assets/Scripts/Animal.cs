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


        public Image image;

        public AnimalData animalData;
        public string animalName;
        public bool canDoTrick;
        public Diet diet;
        public string leavesReaction;
        public string meatReaction;

        // Start is called before the first frame update
        void Start()
        {
            image.sprite = animalData.artwork;
            diet = animalData.diet;

            animalName = animalData.animalName;
            leavesReaction = animalData.leavesReaction;
            meatReaction = animalData.meatReaction;
        }

        public void TextBubble(string text)
        {
            Balloon.SetActive(true);
            textField.text = text;
        }

        public IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
