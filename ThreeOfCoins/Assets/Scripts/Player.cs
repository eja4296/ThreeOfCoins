using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player Class
// This will be for every human player
public class Player : MonoBehaviour {
    // Attributes
    int vote; // Which option the player votes for
    int voteWeight; // How much weight the player's vote is given
    // int score // ???

	// Use this for initialization
	void Start () {
		
	}


    int Vote()
    {
        return vote * voteWeight;
    }

}
