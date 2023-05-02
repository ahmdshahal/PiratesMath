using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    public GameObject soal, score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void feedback()
    {
        soal.GetComponent<soal>().control(1);
        if(gameObject.name == "benar")
        {
            score.GetComponent<score>().skor += 15;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
