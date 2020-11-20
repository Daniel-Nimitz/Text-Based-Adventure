using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



    public class StatTracker : MonoBehaviour
    {
        public Slider strengthSlider;
        public Slider corruptionSlider;
        public Slider arcanaSlider;

        public Text StrengthText;
        public Text ArcanaText;
        public Text CorruptionText;
    //add these three stats to the easy save system
        public int strength;
        public int arcana;
        public int corruption;

        public int maxStrength;
        public int maxArcana;
        public int maxCorruption;
    

        public Text InventoryText;
        public Text ChoiceTraitText;

    //Add these two lists to the easy save files
        public List<string> importantHappeningsList = new List<string>();

        public List<string> choiceTraits = new List<string>();

    private void Awake()
    {
        SetInitialPlayerStats();
        CreateInitialImportantHappenings();
    }

        public void AddStrength(int strengthToAdd)
        {
            strength += strengthToAdd;
            strengthSlider.value += strengthToAdd;
            StrengthText.text = "Strength: " + strength + "/" + maxStrength;

    }

        public void AddArcana(int arcanaToAdd)
        {
            arcana += arcanaToAdd;
            arcanaSlider.value += arcanaToAdd;
            ArcanaText.text = "Arcana: " + arcana + "/" + maxArcana;
    }

        public void AddCorruption(int corruptionToAdd)
        {
            corruption += corruptionToAdd;
            corruptionSlider.value += corruptionToAdd;
            CorruptionText.text = "Corruption: " + corruption + "/" + maxCorruption;
    }

        public void SetInitialPlayerStats()
        {
        //we set the sliders to match the current stats of the character
            strengthSlider.value = strength;
            arcanaSlider.value = arcana;
            corruptionSlider.value = corruption;
            StrengthText.text = "Strength: " + strength + "/" + maxStrength;
            ArcanaText.text = "Arcana: " + arcana + "/" + maxArcana;
            CorruptionText.text = "Corruption: " + corruption + "/" + maxCorruption;
    }


        private void CreateInitialImportantHappenings() {
            importantHappeningsList.Add("Backpack");
            importantHappeningsList.Add("Armor");
            importantHappeningsList.Add("Sword");
            string inventoryAsString = string.Join(",", importantHappeningsList);
            InventoryText.text = "Important Happenings: " + inventoryAsString;

    }
 
    }
