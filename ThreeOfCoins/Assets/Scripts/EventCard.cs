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
    List<string> effects; // What avatar attributes it affects
    List<int> effectStrengths; // How much it affects the attribute
    FightCard item;
    // Possibly multilayer events

    // Use this for initialization
    void Start () {
		
	}
	
    // don't want the right choice to be obvious (risk vs reward)

}
