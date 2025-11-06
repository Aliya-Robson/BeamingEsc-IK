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
            SceneManager.LoadScene("EndScene");
        }

        // Option B: By layer
        if (other.gameObject.layer == LayerMask.NameToLayer("PlayerBody"))
        {
            SceneManager.LoadScene("EndScene");
        }
    }


}