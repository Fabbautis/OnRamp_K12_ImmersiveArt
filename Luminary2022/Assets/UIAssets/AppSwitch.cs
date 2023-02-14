using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppSwitch : MonoBehaviour
{
    [SerializeField] public GameObject[] apps;
    [SerializeField] private GameObject currApp;
    [SerializeField] private int appNum;

    private void Start()
    {
        Debug.Log("App index: " + appNum);
        Debug.Log("App count: " + apps.Length);
        currApp = apps[appNum];
    }


    public void Next()
    {
        apps[appNum].SetActive(false);
        appNum = (appNum + 1) % apps.Length;
        apps[appNum].SetActive(true);
        currApp = apps[appNum];
    }

    public void Previous()
    {
        apps[appNum].SetActive(false);
        appNum--;
        if (appNum < 0) appNum = apps.Length - 1;
        apps[appNum].SetActive(true);
        currApp = apps[appNum];
    }

    public void OpenActivity()
    {
        Debug.Log("Launching: " + currApp.name);
        LoadActivity(appNum);

    }

    //Load activity
    private void LoadActivity(int appNum)
    {
        switch (appNum)
        {
            case 0:
                //load Tokaido
                SceneManager.LoadScene("AR_Objects");
                break;
            case 1:
                SceneManager.LoadScene("Sound_Scapes");
                break;
            case 2:
                SceneManager.LoadScene("Beyond_The_Frame");
                break;
            default:
                Debug.Log("Invalid option. Please enter a number between 0 and 2.");
                break;
        }
    }
}
