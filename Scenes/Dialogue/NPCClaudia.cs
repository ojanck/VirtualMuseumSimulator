using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class NPCClaudia : MonoBehaviour
{

    public GameObject multiplechoice;
    public GameObject dialogueGUI;
    public bool outOfRange = true;

    private DialogueNPC dialogueSystem;

    public string Name;

    [TextArea(5, 10)]
    public string[] sentences;

    void Start()
    {
        dialogueSystem = FindObjectOfType<DialogueNPC>();
    }

    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            multiplechoicestrt();
        }
    }

    public void multiplechoicestrt()
    {
        this.gameObject.GetComponent<NPCClaudia>().enabled = true;
        outOfRange = false;
        dialogueGUI.SetActive(true);
        if (outOfRange == false)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                multiplechoice.SetActive(true);
                FindObjectOfType<MultipleChoice>().Start();
            }
        }
    }

    public void OnTriggerExit()
    {
        outofrange();
    }

    public void outofrange()
    {
        outOfRange = true;
        if (outOfRange == true)
        {
            StopAllCoroutines();
            dialogueGUI.SetActive(false);
            //dialogueGUI.SetActive(false);
        }
    }
}

