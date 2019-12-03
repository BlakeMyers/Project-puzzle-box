using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    bool pauseScreenactive = false;
    public GameObject pauseScreen;
    public GameObject HUD;
    public Text timeText;
    public Text HighscoreText;
    float time = 0.0f;
    float scoretime = 100.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!pauseScreenactive)
        {
            time += Time.deltaTime;
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey("escape"))
        {
            Pause();
        }

        timeText.text = "Time: " + time.ToString("0.0");
        HighscoreText.text = "Best Time: " +scoretime.ToString("0.0");
        if (scoretime >= time)
            timeText.color = Color.green;
        if (scoretime < time)
            timeText.color = Color.red;
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = (false);
#else
        Application.Quit();
#endif
    }
    void Pause()
    {
        if (!pauseScreenactive)
        {
            pauseScreen.SetActive(true);
            HUD.SetActive(false);
            pauseScreenactive = true;
        }
    }
    public void Resume()
    {
        pauseScreen.SetActive(false);
        HUD.SetActive(true);
        pauseScreenactive = false;
    }
    public void Load()
    {
        SceneManager.LoadScene(0);
    }
}