using UnityEngine;
using UnityEngine.UI;

public class Diem : MonoBehaviour
{
    public Text ScoreText;
    int Score = 0;
    AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        GameObject audioObject = GameObject.FindGameObjectWithTag("Audio");
        if (audioObject != null)
        {
            audioManager = audioObject.GetComponent<AudioManager>(); // Corrected method name
        }
        else
        {
            Debug.LogError("No GameObject with tag 'Audio' found in the scene.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Score++;
        ScoreText.text = "Hoa hồng: " + Score;
        Destroy(collision.gameObject);
        audioManager.PlaySFX(audioManager.checkpoint);
    }
}
