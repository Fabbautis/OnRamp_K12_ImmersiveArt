using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppSwitch : MonoBehaviour
{
    [SerializeField] public GameObject[] apps;
    [SerializeField] private GameObject currApp;
    [SerializeField] private int appNum;

    private void Start()
    {
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

    }

}
