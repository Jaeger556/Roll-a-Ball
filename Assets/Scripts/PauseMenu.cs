using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject player;
    public TMP_Dropdown dropDown;
    public Slider speedSlider;
    public float scale = 2f;
    public TMP_Text speedValue;
    
    private Renderer playerRenderer;

    
    void Start()
    {
        //speedSlider.onValueChanged.AddListener(delegate {ChangeSpeed();});
        playerRenderer = player.GetComponent<Renderer>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();

            } 
            else
            {
                Pause();
            }
        }

        speedValue.SetText(speedSlider.value.ToString("0.##"));

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = ChangeSpeed();
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Oversize()
    {
        player.transform.localScale = player.transform.localScale + new Vector3(scale, scale, scale);
        player.transform.localPosition = player.transform.localPosition + new Vector3(0, 1, 0);
    }

    public void ChangeColor()
    {
        if(dropDown.value == 0)
        {
            playerRenderer.material.SetColor("_Color", Color.cyan);
        }

        if(dropDown.value == 1)
        {
            playerRenderer.material.SetColor("_Color", Color.red);
        }

        if(dropDown.value == 2)
        {
            playerRenderer.material.SetColor("_Color", Color.green);
        }
    }

    public float ChangeSpeed()
    {
        Time.timeScale = speedSlider.value;

        return Time.timeScale;
    }

}
