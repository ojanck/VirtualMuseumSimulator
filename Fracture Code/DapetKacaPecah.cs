using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DapetKacaPecah : MonoBehaviour
{
    [SerializeField] Text nilai;
    public float pecahh = 0f;
    //[SerializeField] float masukpecah = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void nambahnilai()
    {
        pecahh++;
        nilai.text = pecahh.ToString("0");
    }

}
