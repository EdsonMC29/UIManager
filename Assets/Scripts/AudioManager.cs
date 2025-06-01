using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource buttonPlaySound;
    [SerializeField] private AudioSource musicSound;
    public static AudioManager Instance { get; private set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayMusicSound(AudioClip music)
    {
        musicSound.PlayOneShot(music);
    }
    public void PlaySound(AudioClip buttonPlay)
    {
        buttonPlaySound.PlayOneShot(buttonPlay);
    }

}
