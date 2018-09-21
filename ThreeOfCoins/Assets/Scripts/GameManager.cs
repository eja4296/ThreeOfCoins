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
    public List<EventCard> allEventCards; // List of all Event cards in the game (may be read in as a txt file later)
    public List<int> eventCardPlayed; // Keep a list of what event cards were played so they don't get played again
    public int numberOfEvents; // Number of events to add to event deck
    public int turn; // Current turn of game
    

	// Use this for initialization
	void Start () {
        // Set turn to 1
        turn = 1;
        // Create Event Deck first
        CreateEventDeck();
        

	}
	
	// Update is called once per frame
    // Only this class should need the Update function
	void Update () {
		
	}


    // Create Event Deck
    // Get set number of all event cards, "shuffle them", lay them out face down
    void CreateEventDeck()
    {
        for(int i = 0; i < numberOfEvents; i++)
        {
            int randomNum = Random.Range(0, allEventCards.Count - 1);
            eventDeck.Add(allEventCards[randomNum]);
            allEventCards.Remove(eventDeck[i]);
        }

    }

    // Start Event
    // Display the description of the event
    void Event()
    {
        EventCard currentEvent = eventDeck[turn - 1];

        // Show description
        Debug.Log(currentEvent.description);

        // Show voting options
        // Handle Event
        // Show voting options and effects
        Debug.Log(currentEvent.effects);
        Debug.Log(currentEvent.effectStrengths);
    }

    // Handle vote
    int Vote(EventCard currEvent)
    {
        return 0;
    }
        
        

        

        // Handle Outcome
        
        // If NPC fights, Handle Combat
            // Draw 3 cards from fight deck

            // Handle fight card vote

            // Apply fight card effect

            // Handle NPC move

            // Loop until combat finished

        // Loop event until complete, then start next one
            


 
    
}
