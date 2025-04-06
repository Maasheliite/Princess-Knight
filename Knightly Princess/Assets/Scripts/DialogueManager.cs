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
    public GameObject BBSprite;
    public GameObject WizardSprite;
    public GameObject FarmerSprite;
    public GameObject DemonSprite;

    public AudioSource dialogueSound;
    public float pitchVariance;
    public float pitch;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        if (dialogue.name == "Princess")
        {
            PrincessSprite.SetActive(true);
            pitch = 1.45f;
        }

        if (dialogue.name == "Farmer")
        {
            FarmerSprite.SetActive(true);
            pitch = 0.65f;
        }
        if (dialogue.name == "Berry Brute")
        {
            BBSprite.SetActive(true);
            pitch = 0.95f;
        }
        if (dialogue.name == "Wizard")
        {
            WizardSprite.SetActive(true);
            pitch = 1.15f;
        }

        if (dialogue.name == "Demon Guard")
        {
            DemonSprite.SetActive(true);
            pitch = 0.25f;
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
        dialogueSound.enabled = true;
        dialogueSound.Play();
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueSound.pitch = Random.Range(pitch - pitchVariance, pitch + pitchVariance);
            dialogueText.text += letter;
            yield return null;
        }
        dialogueSound.enabled = false;
    }

    void EndDialogue()
    {
        PrincessSprite.SetActive(false);
        FarmerSprite.SetActive(false);
        BBSprite.SetActive(false);
        WizardSprite.SetActive(false);
        DemonSprite.SetActive(false);


        animator.SetBool("IsOpen", false);
        FindObjectOfType<PlayerMovement>().StartFighting();
    }
}
