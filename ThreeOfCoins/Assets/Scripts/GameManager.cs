using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game Manager Class
// This will be used for handling the main gameplay
public class GameManager : MonoBehaviour {
    // Attributes
    Avatar avatar; // Instance of the avatar controlled by the players
    List<Player> players; // All players playing the game
    List<EventCard> eventDeck; // Deck of Event Cards to determine ecounters
    List<int> eventCardPlayed; // Keep a list of what event cards were played so they don't get played again
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    // Only this class should need the Update function
	void Update () {
		
	}
}
