using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Button : MonoBehaviour
{
    public GameObject button;
    public Animator anima;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("VButton");
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        
        // anima = GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
        anima.SetTrigger("workoutChange");
        audioSource.Play();        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
    }

    void Update(){}
}
