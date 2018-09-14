using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Event Card Class
// This class will be for each of the encounters in the dungeon
// (May want to read these in as a text file)
public class EventCard : MonoBehaviour {
    // Attributes
    string description;
    NPC nonPlayerCharacter;
    List<string> voteChoices;
    List<string> voteEffects; // What avatar attributes it affects
    List<int> voteEffectStrengths; // How much it affects the attribute

    // Use this for initialization
    void Start () {
		
	}
	

}
