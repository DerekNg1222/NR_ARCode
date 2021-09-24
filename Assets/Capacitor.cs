using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Capacitor : MonoBehaviour
{
    public void OnbuttonCapMainUI()
    {
        SceneManager.LoadScene("CapacitorUIScene");
    }
    public void OnbuttonCapVideo()
    {
        SceneManager.LoadScene("CapacitorVideoScene");
    }
    public void OnbuttonCapHistory()
    {
        SceneManager.LoadScene("CapacitorHistoryScene");
    }
    public void OnbuttonCapTypes()
    {
        SceneManager.LoadScene("CapacitorTypesScene");
    }
    public void OnbuttonCapTypesMicaCapacitor()
    {
        SceneManager.LoadScene("CapacitorTypesSceneMicaCapacitor");
    }
    public void OnbuttonCapTypesElectrolyticCapacitor()
    {
        SceneManager.LoadScene("CapacitorTypesSceneElectrolyticCapacitor");
    }
    public void OnbuttonCapTypesPaperCapacitor()
    {
        SceneManager.LoadScene("CapacitorTypesScenePaperCapacitor");
    }
    public void OnbuttonCapTypesFilmCapacitor()
    {
        SceneManager.LoadScene("CapacitorTypesSceneFilmCapacitor");
    }
}
