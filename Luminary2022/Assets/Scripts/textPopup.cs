using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class textPopup : MonoBehaviour
{
    public TMP_Text TextBox;
    [FormerlySerializedAs("A_boolName")] public string animBoolName;
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
                Animm.SetBool(animBoolName, true);
            }

            toggle = true;
            TextBox.text = InputText;
        } else {
            foreach (Animator Animm in Animations)
            {
                Animm.SetBool(animBoolName, false);
            }

            TextBox.text = "";
            toggle = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}