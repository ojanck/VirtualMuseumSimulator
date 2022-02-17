using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fracture : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fractured;
    public GameObject fractureGUI;
    //public GameObject dialogueGUI;
    public GameObject Object;
    public GameObject StartTimer;
    public GameObject wall;
    public GameObject Textangka;

    public bool dialogueActive = false;
    public bool outOfRange = true;

    //int maxPlatform = 0;

    //public void EnterRange()
    //{
    //}

    //public void OutOfRange()
    //{
    //}
    // Update is called once per frame
    private void Start()
    {
        //pecahh = masukpecah;
    }

    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            pecah();
        }
    }

    public void pecah()
    {
        this.gameObject.GetComponent<fracture>().enabled = true;
        outOfRange = false;
        fractureGUI.SetActive(true);
        if (dialogueActive == true)
        {
            fractureGUI.SetActive(false);
        }

        if (outOfRange == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 oldpos = transform.position;
                Instantiate(fractured, oldpos, Quaternion.identity);
                fractureGUI.SetActive(false);
                //dialogueGUI.SetActive(false);
                //Destroy(gameObject);
                Object.SetActive(false);
                StartTimer.SetActive(true);
                wall.SetActive(true);
                Textangka.SetActive(true);
                FindObjectOfType<DapetKacaPecah>().nambahnilai();
                //FindObjectOfType<GameManager>().GameOver();
            }
        }
    }
    public void stopliatin()
    {
        Textangka.SetActive(false);
    }
    public void addscore()
    {

    }

    //public void stop()
    //{
    //    outOfRange = true;
    //}

    public void OnTriggerExit(Collider other)
    {
        outofrange();
    }

    public void outofrange()
    {
        outOfRange = true;
        if (outOfRange == true)
        {
            dialogueActive = false;
            StopAllCoroutines();
            fractureGUI.SetActive(false);
            //dialogueGUI.SetActive(false);
        }
    }
}
