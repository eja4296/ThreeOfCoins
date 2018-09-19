using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player Class
// This will be for every human player
public class Player : MonoBehaviour {
    // Attributes
    public int voteChoice; // Which option the player votes for
    public int voteWeight; // How much weight the player's vote is given
    // int score // ???

	// Use this for initialization
	void Start () {
		
	}


    int Vote()
    {
        return voteChoice * voteWeight;
    }

    // Properties
    public int VoteChoice
    {
        get { return voteChoice; }
        set { voteChoice = value; }
    }

    public int VoteWeight
    {
        get { return voteWeight; }
        set { voteWeight = value; }
    }

}
