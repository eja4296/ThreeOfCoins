using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Fight Card Class
// Fight cards are for the avatar to have in combat situations
// (May want to read these in as a text file)
public class FightCard : MonoBehaviour {
    // Attributes
    public string description; // Description of the fight card
    public List<string> effects; // What avatar attributes it affects
    public List<int> effectStrengths; // How much it affects the attribute

	// Use this for initialization
	void Start () {
		
	}

    // could apply fightcard here or in Avatar

}
