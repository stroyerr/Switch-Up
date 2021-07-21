using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class dialogueController : MonoBehaviour
{
    public GameObject canvas;
    private bool isShowing = false;
    public Text name;
    public Text dialogueText;
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        isShowing = false;
        introDialogue();
        sentences = new Queue<string>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            isShowing = !isShowing;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            displayNextSentence();
        }

    }


    

    public void startDialogue(dialogue dialogue)
    {
        name.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentence)
        {
            sentences.Enqueue(sentence);
        }

        displayNextSentence();

        
    }

    public void displayNextSentence()
    {
        int count = sentences.Count;

        if (sentences.Count == 0)
        {
            endDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void endDialogue()
    {

    }

    // Update is called once per frame


    private void FixedUpdate()
    {
        if (isShowing)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
    }

    public void introDialogue()
    {
        isShowing = true;

    }
}
