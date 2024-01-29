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
    public string A_boolName;
    public string InputText;
    private bool toggle;
    public List<Animator> Animations;
   // public Animator BS;
    
    // Start is called before the first frame update
    void Start()
    {
        toggle = false;
    }

    public void DisplayText()
    {
        
            if (toggle == false)
            {
            foreach (Animator Animm in Animations)
            {
                Animm.SetBool(A_boolName, true);
                
            }
            toggle = true;
            TextBox.text = InputText;
            }

            if (toggle == true)
            {
                foreach (Animator Animm in Animations)
                {
                    Animm.SetBool(A_boolName, false);
                }
                TextBox.text.Replace(A_boolName, "");
                toggle = false;
            }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
