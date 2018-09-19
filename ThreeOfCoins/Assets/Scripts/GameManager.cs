using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game Manager Class
// This will be used for handling the main gameplay
public class GameManager : MonoBehaviour {
    // Attributes
    public Avatar avatar; // Instance of the avatar controlled by the players
    public List<Player> players; // All players playing the game
    public List<EventCard> eventDeck; // Deck of Event Cards to determine ecounters
    public List<int> eventCardPlayed; // Keep a list of what event cards were played so they don't get played again
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    // Only this class should need the Update function
	void Update () {
		
	}


    // Create Event Deck
    // Get set number of all event cards, "shuffle them", lay them out face down

    // Start Event
    // Display the description of the event
        
        // Handle Event
        // Show voting options and effects

        // Handle vote

        // Handle Outcome
        
        // If NPC fights, Handle Combat
            // Draw 3 cards from fight deck

            // Handle fight card vote

            // Apply fight card effect

            // Handle NPC move

            // Loop until combat finished

        // Loop event until complete, then start next one
            


 
    
}
