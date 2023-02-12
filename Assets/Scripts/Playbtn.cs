using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbtn : MonoBehaviour
{
    
    public void Play()
    {
        Debug.Log("Starting.");
        SceneManager.LoadScene("MiniGame");
    }

}
