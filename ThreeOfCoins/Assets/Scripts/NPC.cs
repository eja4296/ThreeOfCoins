using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NPC class
// This class is for all non-player characters
public class NPC : MonoBehaviour {
    // Attributes
    string description; // Description of NPC
    int health; // NPC's health stat
    int attackStrength;
    FightCard item; // Item (Fight Card) that NPC may be holder
    List<string> effects; // What avatar attributes it affects
    List<int> effectStrengths; // How much it affects the attribute


    // Use this for initialization
    void Start () {
		
	}
	

}
