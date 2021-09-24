using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LED : MonoBehaviour
{
    public void OnbtnLEDVideo()
    {
        SceneManager.LoadScene("LEDVideo");
    }
    public void OnbtnLEDMianUI()
    {
        SceneManager.LoadScene("LEDUIScene");
    }
    public void OnbtnLEDHistory()
    {
        SceneManager.LoadScene("LEDHistoryScene");
    }
    public void OnbtnLEDTypes()
    {
        SceneManager.LoadScene("LEDTypesScene");
    }
    public void OnbtnLEDTypesAcLED()
    {
        SceneManager.LoadScene("AC LED Scene");
    }
    public void OnbtnLEDTypesAppLED()
    {
        SceneManager.LoadScene("Application LED Scene");
    }
    public void OnbtnLEDTypesHightPowerLED()
    {
        SceneManager.LoadScene("Hight Power LED Scene");
    }
    public void OnbtnLEDTypesMiniatureLED()
    {
        SceneManager.LoadScene("Miniature LED Scene");
    }
}
