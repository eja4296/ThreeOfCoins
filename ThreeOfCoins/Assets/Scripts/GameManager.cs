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
    public FightCard[] currentFightCards;
    public int numberOfEvents; // Number of events to add to event deck
    public int turn; // Current turn of game
    

	// Use this for initialization
	void Start () {
        // Set turn to 1
        turn = 1;
        // Create Event Deck first
        CreateEventDeck();
        Event();
        
        

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
        Debug.Log(currentEvent.effects[0]);
        Debug.Log(currentEvent.effectStrengths[0]);

        // Vote on event
        int finalVote = Vote(currentEvent);
        Debug.Log(finalVote);

        // If there is combat
        if (currentEvent.combat)
        {
            if(avatar.health > 0 || currentEvent.nonPlayerCharacter.health > 0)
            {
                HandleCombat(currentEvent);
            }
            
        }
    }

    // Handle vote
    // Get all of the player votes
    // Apply their weight to the vote
    int Vote(EventCard currEvent)
    {
        // Temporary array to hold vote weights
        int[] tempVotes = new int[currEvent.effects.Count];
        int topVote = 0;

        // Loop through players to calculate vote weights
        for(int i = 0; i < players.Count; i++)
        {
            tempVotes[players[i].voteChoice] += players[i].voteWeight;
            if(topVote < tempVotes[players[i].voteChoice])
            {
                topVote = players[i].voteChoice;
            }
        }

        // Return the top vote
        return topVote;
    }
        
    
    void HandleCombat(EventCard currentEvent)
    {
        // Avatar attack
        currentFightCards = new FightCard[3];

        for (int i = 0; i < 3; i++)
        {
            int randomNum = Random.Range(0, avatar.fightDeck.Count - 1);
            currentFightCards[i] = avatar.fightDeck[randomNum];


        }

        for(int i = 0; i < currentFightCards.Length; i++)
        {
            Debug.Log(currentFightCards[i].description);
            Debug.Log(currentFightCards[i].effects);
            Debug.Log(currentFightCards[i].effectStrengths);
        }

        int finalVote = Vote(currentEvent);
        Debug.Log(finalVote);

        Debug.Log(currentFightCards[finalVote].effects);
        Debug.Log(currentFightCards[finalVote].effectStrengths);

        // Apply Effect
            // Attack to NPC
            // Health to avatar
            // Block by avatar

        // NPC attack
        int randomEffect = Random.Range(0, currentEvent.nonPlayerCharacter.effectStrengths.Count);

        Debug.Log(currentEvent.nonPlayerCharacter.effects[randomEffect]);
        Debug.Log(currentEvent.nonPlayerCharacter.effectStrengths[randomEffect]);

        // Apply Effect
            // Attack to avatar
            // ... (what else)

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
