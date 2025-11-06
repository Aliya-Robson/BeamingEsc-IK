using UnityEngine;
using UnityEngine.UI;

public class FadeToBlackOnly : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1.2f;

    public void StartFade()
    {
        StartCoroutine(Fade());
    }

    private System.Collections.IEnumerator Fade()
    {
        float t = 0f;
        Color c = fadeImage.color;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            c.a = Mathf.Lerp(0f, 1f, t / fadeDuration);
            fadeImage.color = c;
            yield return null;
        }

        // freeze game here
        Time.timeScale = 0f;
    }
}
