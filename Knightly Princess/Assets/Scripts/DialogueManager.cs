using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMPro.TMP_Text nameText;

    public TMPro.TMP_Text dialogueText;

    public Animator animator;

    public Queue<string> sentences;

    public GameObject diaFrame;
    public GameObject PrincessSprite;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        if (dialogue.name == "Princess")
        {
            diaFrame.SetActive(true);
            PrincessSprite.SetActive(true);
        }

        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        diaFrame.SetActive(false);
        PrincessSprite.SetActive(false);

        animator.SetBool("IsOpen", false);
        FindObjectOfType<PlayerMovement>().StartFighting();
    }
}
