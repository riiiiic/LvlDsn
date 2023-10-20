using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeScene : MonoBehaviour
{
    public Transform chara;//define character
    public bool triggered = false;
    public Vector3 targetPosition;
    public AudioSource source;
    public bool Triggered { get => triggered; set => triggered = value; }
    
// Start is called before the first frame update
void Start()
    {
        
    }
    //I need to move the character sprite from one position to another when they hit 'Space'

    //define destination

    // and if the player presses SPACEBAR, getKey
    // then the player is moved to a destination position.
    //move code(move to scene 2 at first door, to scene 3 at second door)
    //blackout screen on action
    //whiteout screen after player arrives

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
            //selection text
            if (Input.GetKeyDown("e"))
            {
                source.Play();
                chara.transform.position = targetPosition;
                Debug.Log("Is this running?");
            }
            else
            {
               //void
            }
        }
    }
}
