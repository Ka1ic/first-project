using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wait : MonoBehaviour
{
    public GameObject Player;
    public Text t;
    public int second = 0;
    public int minut = 0;
    public int hour = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(T());
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
    }
    IEnumerator T()
    {
        while (true)
        {

            yield return new WaitForSeconds(1);
            if (hour < 10)
            {
                if (minut < 10)
                {
                    if(second < 10)
                    {
                        t.text = "0" + second + ":0" + minut + ":0" + hour;
                    }
                    else
                    {
                        t.text = second + ":0" + minut + ":0" + hour;
                    }
                }
                else
                {
                    if(second < 10)
                    {
                        t.text = "0" + second + ":" + minut + ":0" + hour;
                    }
                    else
                    {
                        t.text = second + ":" + minut + ":0" + hour;
                    }
                }
            }
            else
            {
                if (minut < 10)
                {
                    if (second < 10)
                    {
                        t.text = "0" + second + ":0" + minut + ":" + hour;
                    }
                    else
                    {
                        t.text = second + ":0" + minut + ":" + hour;
                    }
                }
                else
                {
                    if (second < 10)
                    {
                        t.text = "0" + second + ":" + minut + ":" + hour;
                    }
                    else
                    {
                        t.text = second + ":" + minut + ":" + hour;
                    }
                }
            }
           
            second++;
            if(second > 59)
            {
                second = 0;
                minut++;
                if(minut > 59)
                {
                    minut = 0;
                    hour++;
                }
            }
        }
    } 
}
