using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static Unity.VisualScripting.Member;

public class Button : MonoBehaviour
{
    public Button Exclaim;
    public Button Magnify;
    public GameObject txtbox;

    public Transform chara;//define character
    public bool triggered = false;

    public GameObject interactiveObject;
    public bool Triggered { get => triggered; set => triggered = value; }

    // Start is called before the first frame update
    void OnEnable()
    {
        Exclaim.gameObject.SetActive(false);
        Magnify.gameObject.SetActive(false);
        txtbox.gameObject.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered = true;
    }


    private void OnTriggerExit2D(Collider2D chara)
    {
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            Exclaim.gameObject.SetActive(true);
        }
        else 
        { 
            Exclaim.gameObject.SetActive(false);
        }

        void OnClick()
        {
            txtbox.gameObject.SetActive(true);
            Debug.Log("Clicked!");
        }
    }
}
