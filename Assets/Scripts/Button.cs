using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Button : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Vbutton;
    public Animator anm;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anm.Play("Rotate");
        Debug.Log("Button Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        anm.Play("None");
        Debug.Log("Button Relised");
    }

    // Start is called before the first frame update
    void Start()
    {
        Vbutton = GameObject.Find("VirtualButton");
        Vbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        anm.GetComponent<Animator>();
    }
}
