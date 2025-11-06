using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Option A: By tag
        if (other.CompareTag("Character"))
        {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            // Time.timeScale = 0f;
            FindObjectOfType<FadeToBlackOnly>().StartFade();
        }

        // Option B: By layer
        if (other.gameObject.layer == LayerMask.NameToLayer("PlayerBody"))
        {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            // Time.timeScale = 0f;
            FindObjectOfType<FadeToBlackOnly>().StartFade();
        }
    }


}