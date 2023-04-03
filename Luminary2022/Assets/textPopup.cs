using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class textPopup : MonoBehaviour
{
    public TMP_Text TextBox;
    public string InputText;
    public string A_boolName;
   
    public Animator BS;
    //nathan thinks this project is ^^^
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DisplayText()
    {
        BS.SetBool(A_boolName, true);
        TextBox.text = InputText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
