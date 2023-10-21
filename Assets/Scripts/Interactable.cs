using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactable : MonoBehaviour
{
    public GameObject buttonObject; // This needs to be a unique object with the OnClick set to this referenced script's EnableTextBox function.

    public GameObject speechBubble; // This is a reference to the parent Speech Bubble object on the Canvas
    public TextMeshProUGUI textBox; // This is a reference to the child object of the Speech Bubble containing the Text

    public string textBoxText; // This is the text that you want to appear in the text box for this interactable object.

    private void Update()
    {
        if(textBox.isActiveAndEnabled) // This checks if the textBox is active and enabled (currently visible on screen)
        {
            if (Input.GetMouseButtonDown(0)) // This checks if the player has clicked the left mouse button this frame only
            {
                speechBubble.gameObject.SetActive(false); // This deactivates the speech bubble
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") // This checks if the object that collided with the trigger is in fact the player.
        {
            buttonObject.SetActive(true); // This makes the relevant button object appear.
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player") // This checks if the object that collided with the trigger is in fact the player.
        {
            buttonObject.SetActive(false); // This makes the relevant button object disappear.
        }
    }

    public void EnableTextBox() // This function is called by the buttonObject's OnClick in the inspector.
    {
        speechBubble.SetActive(true); // This enables the speech bubble object to be active and enabled.
        textBox.text = textBoxText; // This changes the text within the speech bubble.
    }
}
