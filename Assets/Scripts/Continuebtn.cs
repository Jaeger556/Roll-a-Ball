using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continuebtn : MonoBehaviour
{
    public void Continue()
    {
        Debug.Log("Continuing.");
        SceneManager.LoadScene("Exit");
    }
}
