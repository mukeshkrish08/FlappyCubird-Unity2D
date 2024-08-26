using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowManager : MonoBehaviour
{
    public GameObject aboutPanel;
    public GameObject mainMenu;
    public GameObject themePanel;

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        aboutPanel.SetActive(false);
        themePanel.SetActive(false);
    }
    public void ShowAboutPanel()
    {
        aboutPanel.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void ShowThemePanel()
    {
        Debug.Log("ShowMainMenu called");
        themePanel.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void OpenLink(string url)
    {
        Application.OpenURL(url);
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        // If we're in the Unity editor, stop playing the scene
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE || UNITY_ANDROID || UNITY_IOS
        // For standalone builds and mobile platforms, quit the application
        Application.Quit();
#endif
    }
}
