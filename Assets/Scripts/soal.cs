using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soal : MonoBehaviour
{
    public GameObject result;
    int urutan = 0;
    // Start is called before the first frame update
    void Start()
    {
        set_peti();
    } 

    public void control(int i)
    {
        if (urutan < transform.childCount-1)
        {
            urutan += i;
            set_peti();
        } else
        {
            result.SetActive(true);
        }
        
    }

    public void set_peti()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        transform.GetChild(urutan).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
