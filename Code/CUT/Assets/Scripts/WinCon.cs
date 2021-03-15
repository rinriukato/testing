﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCon : MonoBehaviour
{
    public GameObject winText;

    // Update is called once per frame
    void Update()
    {
        GameObject Scissors = GameObject.Find("Scissors");
        Scissors scissors = Scissors.GetComponent<Scissors>();

        // If the blade has cut 5 or more bamboo within the session, end the game with a win
        if (scissors.count >= 5)
        {
            Debug.Log("Game end");
            Destroy(gameObject);
            winText.SetActive(true);
        }
    }
}
