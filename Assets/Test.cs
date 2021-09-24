using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public void OnbuttonBattery()
    {
        SceneManager.LoadScene("Battery");
    }
    public void OnbuttonSwitch()
    {
        SceneManager.LoadScene("Switch");
    }
    public void OnbuttonTransistor()
    {
        SceneManager.LoadScene("Transistor");
    }
}
