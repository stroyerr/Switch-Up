 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogue dialogue;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            triggerDialogue();
        }

        
    }

    public void triggerDialogue()
    {
        FindObjectOfType<dialogueController>().startDialogue(dialogue);
    }
}
