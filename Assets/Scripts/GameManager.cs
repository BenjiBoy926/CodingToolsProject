using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerHealth playerHealth;

    private void Update()
    {
        if (playerHealth.health <= 0)
        {
            // Do a thing!
        }
    }
}
