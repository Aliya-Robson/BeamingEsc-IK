using UnityEngine;

public class RepeatAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        InvokeRepeating(nameof(PlayAlarm), 0f, 10f);
    }

    void PlayAlarm()
    {
        audioSource.Play();
    }
}
