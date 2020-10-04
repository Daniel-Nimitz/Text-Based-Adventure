using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;



    public class StatTracker : MonoBehaviour
    {
        public Slider strengthSlider;
        public Slider corruptionSlider;
        public Slider arcanaSlider;

        public int strength;
        public int corruption;
        public int arcana;

        public Text InventoryText;

        public List<string> inventoryItems = new List<string>();

        private void Awake()
        {
            SetInitialPlayerStats();
            CreateInitialInventory();
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

    private void CreateInitialInventory() {
        inventoryItems.Add("Backpack");
        inventoryItems.Add("Armor");
        inventoryItems.Add("Sword");
        string inventoryAsString = string.Join(",", inventoryItems);
        InventoryText.text = "Inventory: " + inventoryAsString;

    }
    }
