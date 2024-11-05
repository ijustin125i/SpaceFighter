// Managing time elapsed/game logic

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int timeElapsed = 0;  
    public TMPro.TextMeshProUGUI timeText; 
    private float timer = 0f;  // Internal timer to track elapsed time

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Ensure the GameManager persists across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Increment the timer by the time elapsed since the last frame
        timer += Time.deltaTime;

        // Check if a second has passed
        if (timer >= 1f)
        {
            timeElapsed++; // Increment timeElapsed every second
            timer = 0f; // Reset timer
            UpdateTimeUI(); // Update the UI every second
        }
    }

    public void GameOver()
    {
        // Reset the game/Reload scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void UpdateTimeUI()
    {
        timeText.text = "Time Elapsed: " + timeElapsed + "s"; // Update the displayed text
    }
}
