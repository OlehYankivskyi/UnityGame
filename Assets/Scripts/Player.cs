﻿using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject restart;
    public static bool lose = false;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "bomb")
        {
            lose = true;
            restart.SetActive(true);
        }
    }

}
