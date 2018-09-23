using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Event Card Class
// This class will be for each of the encounters in the dungeon
// (May want to read these in as a text file)
public class EventCard : MonoBehaviour {
    // Attributes
    public string description;
    public List<string> options; // Options for the avatar
    
    public List<string> effects; // What avatar attributes it affects
    public List<int> effectStrengths; // How much it affects the attribute
    public NPC nonPlayerCharacter; // If an NPC is part of the event
    public FightCard item; // If a Fight Card is part of the event (dropped by event)
    public bool combat; // If combat is part of the event
    // Possibly multilayer events

    // Use this for initialization
    void Start () {
		
	}
	
    // don't want the right choice to be obvious (risk vs reward)

}
