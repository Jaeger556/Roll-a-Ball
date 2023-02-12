using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exitbtn : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("Exiting.");
        Application.Quit();
    }
}
