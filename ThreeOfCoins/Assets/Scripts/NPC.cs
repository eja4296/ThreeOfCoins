using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NPC class
// This class is for all non-player characters
public class NPC : MonoBehaviour {
    // Attributes
    public string description; // Description of NPC
    public int health; // NPC's health stat
    public int attackStrength;
    public FightCard item; // Item (Fight Card) that NPC may be holder
    public List<string> effects; // What avatar attributes it affects
    public List<int> effectStrengths; // How much it affects the attribute


    // Use this for initialization
    void Start () {
		
	}
	

}
