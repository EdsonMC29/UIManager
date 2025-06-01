using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    [SerializeField] private AudioClip buttonPlaySound;
    [SerializeField] private AudioClip playMusicMenu;

    // Star
    //t is called once before the first execution of Update after the MonoBehaviour is created
    public void StarGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        AudioManager.Instance.PlaySound(buttonPlaySound);
        
    }
    void Start()
    {
        AudioManager.Instance.PlayMusicSound(playMusicMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
