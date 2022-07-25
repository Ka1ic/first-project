using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
    public GameObject Player;
    public GameObject oter;
    public Text t;
    static int s = 0;
    void Start()
    {
        
    }

    void Update()
    {
        t.text = s + "/45";
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        s++;
        t.text = s + "/45";
        Destroy(oter);
    }
    }
