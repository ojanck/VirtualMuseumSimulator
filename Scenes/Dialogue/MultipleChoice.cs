using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleChoice : MonoBehaviour
{
    //public GameObject background;
    public GameObject GUI;
    public GameObject BeginningDialogue;
    public GameObject BackgroundMuseum;
    public GameObject QuizSiap;
    public GameObject QuizSiap2;
    public GameObject Quiz1;
    public GameObject Quiz2;
    public GameObject Quiz3;
    public GameObject Quiz4;
    public GameObject Quiz5;
    public GameObject Menang;
    public GameObject Kalah;
    public GameObject KalahTelak;
    public GameObject buttonquiz;
    public GameObject Victory;
    public GameObject dialogueGUI;
    [SerializeField] Text kesempatan;

    public float totalkalah = 0f;
    // Start is called before the first frame update
    public void Start()
    {
            FindObjectOfType<PlayerController>().stop();
            FindObjectOfType<PlayerController>().unlock();        
    }

    // Update is called once per frame
    void Update()
    {
        if (BeginningDialogue == true)
        {
            dialogueGUI.SetActive(false);
        }
        if (totalkalah == 3)
        {
            buttonquiz.SetActive(false);
        }
    }

    public void kembali1()
    {
        BackgroundMuseum.SetActive(false);
        BeginningDialogue.SetActive(true);
    }

    public void tidaksiap()
    {
        QuizSiap.SetActive(false);
        BeginningDialogue.SetActive(true);
    }

    public void tidaksiap2()
    {
        QuizSiap2.SetActive(false);
        BeginningDialogue.SetActive(true);
    }

    public void kembali2()
    {
        Menang.SetActive(false);
        BeginningDialogue.SetActive(true);
    }

    public void kembali3()
    {
        Kalah.SetActive(false);
        BeginningDialogue.SetActive(true);
    }

    public void kembali4()
    {
        KalahTelak.SetActive(false);
        BeginningDialogue.SetActive(true);
    }

    public void bckgrnd()
    {
        BeginningDialogue.SetActive(false);
        BackgroundMuseum.SetActive(true);
    }

    public void quizsiap()
    {
        kesempatan.text = "Total Quiz Kalah: " + totalkalah.ToString("0");
        BeginningDialogue.SetActive(false);
        QuizSiap.SetActive(true);
    }

    public void quizsiap2()
    {
        QuizSiap.SetActive(false);
        QuizSiap2.SetActive(true);
    }

    public void quiz1()
    {
        QuizSiap2.SetActive(false);
        Quiz1.SetActive(true);
    }

    public void quiz2()
    {
        Quiz1.SetActive(false);
        Quiz2.SetActive(true);
    }

    public void quiz3()
    {
        Quiz2.SetActive(false);
        Quiz3.SetActive(true);
    }

    public void quiz4()
    {
        Quiz3.SetActive(false);
        Quiz4.SetActive(true);
    }

    public void quiz5()
    {
        Quiz4.SetActive(false);
        Quiz5.SetActive(true);
    }

    public void menangz()
    {
        Quiz5.SetActive(false);
        Menang.SetActive(true);
        Victory.SetActive(true);
    }

    public void kalahz1()
    {
        totalkalah++;
        Quiz1.SetActive(false);
        if (totalkalah == 3)
        {
            KalahTelak.SetActive(true);
        }
        else
        {
            Kalah.SetActive(true);
        }
    }

    public void kalahz2()
    {
        totalkalah++;
        Quiz2.SetActive(false);
        if (totalkalah == 3)
        {
            KalahTelak.SetActive(true);
        }
        else
        {
            Kalah.SetActive(true);
        }
    }

    public void kalahz3()
    {
        totalkalah++;
        Quiz3.SetActive(false);
        if (totalkalah == 3)
        {
            KalahTelak.SetActive(true);
        }
        else
        {
            Kalah.SetActive(true);
        }
    }

    public void kalahz4()
    {
        totalkalah++;
        Quiz4.SetActive(false);
        if (totalkalah == 3)
        {
            KalahTelak.SetActive(true);
        }
        else
        {
            Kalah.SetActive(true);
        }
    }

    public void kalahz5()
    {
        totalkalah++;
        Quiz5.SetActive(false);
        if (totalkalah == 3)
        {
            KalahTelak.SetActive(true);
        }
        else
        {
            Kalah.SetActive(true);
        }
    }

    public void keluar()
    {
        GUI.SetActive(false);
        FindObjectOfType<PlayerController>().Start();
    }

    public void jikakalah()
    {
        
    }
}
