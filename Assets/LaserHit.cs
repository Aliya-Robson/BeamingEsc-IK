using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Option A: By tag
        if (other.CompareTag("Player"))
        {
            EndGame();
        }

        // Option B: By layer
        if (other.gameObject.layer == LayerMask.NameToLayer("PlayerBody"))
        {
            EndGame();
        }
    }

    void EndGame()
    {
        Debug.Log("Laser touched! GAME OVER");

        // restart scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }
}