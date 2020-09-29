using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



    public class StatTracker : MonoBehaviour
    {
        public Slider strengthSlider;
        public Slider corruptionSlider;
        public Slider arcanaSlider;

        public int strength;
        public int corruption;
        public int arcana;

        private void Awake()
        {
            SetInitialPlayerStats();
        }

        public void AddStrength(int strengthToAdd)
        {
            strengthSlider.value += strengthToAdd;
        }

        public void AddArcana(int arcanaToAdd)
        {
            arcanaSlider.value += arcanaToAdd;
        }

        public void AddCorruption(int corruptionToAdd)
        {
            corruptionSlider.value += corruptionToAdd;
        }

        private void SetInitialPlayerStats()
        {
            strengthSlider.value = strength;
            arcanaSlider.value = arcana;
            corruptionSlider.value = corruption;
        }
    }
