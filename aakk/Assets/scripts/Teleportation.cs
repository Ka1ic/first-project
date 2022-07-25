
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleportation : MonoBehaviour
{
    public GameObject Player;
    public GameObject block;
    public GameObject bloc;
    public GameObject bl;
    public GameObject b;
    public Rigidbody2D rb;
    public Rigidbody2D r;
    public Rigidbody2D rbx;
    public Rigidbody2D rbv;
    public Text t;
    public float x=0;
    public float y=0;
    public int a = 0;
    public bool isPortal = true;
    public Transform checkPoint = null;
    static int s = 1;

    public void OnTriggerEnter2D(Collider2D other)
    {
        rb.freezeRotation = false;
        r.freezeRotation = false;
        rbx.freezeRotation = false;
        rbv.freezeRotation = false; 

        if (a==1)
        {
            StartCoroutine(Teleport());
        }
        if (isPortal)
        {
            s--;

            Player.GetComponent<checkPointCreator>().newLvl(x, y);
        }
        if (x!=1113)
        {
            t.text =  s + "";
        }
        else
        {
           t.text = "вітаю ви перемогли, ласкаво просимо в роту" +
                 " ви померли " + s + " раз";   
        }
        
    }


    IEnumerator Teleport()
    {
        if (isPortal)
            Player.transform.position = new Vector2(x, y);
        else
            Player.transform.position = checkPoint.position;

        Rigidbody2D playerRB = Player.GetComponent<Rigidbody2D>();
        playerRB.velocity = new Vector2(0, 0);

        rb.freezeRotation = true;
        block.transform.rotation = new Quaternion(0, 0, 0, 0);
        rb.freezeRotation = false;
        r.freezeRotation = true;
        bloc.transform.rotation = new Quaternion(0, 0, 0, 0);
        r.freezeRotation = false;
        rbx.freezeRotation = true;
        bl.transform.rotation = new Quaternion(0, 0, 0, 0);
        rbx.freezeRotation = false;
        rbv.freezeRotation = true;
        b.transform.rotation = new Quaternion(0, 0, 0, 0);
        rbv.freezeRotation = false;

        yield return null;
        //int weight = (int)playerRB.gravityScale;

        //for (int i = 2; i < weight; i++)
        //{
        //    playerRB.gravityScale = i;
        //    yield return new WaitForSeconds(.05f);
        //}
        //playerRB.gravityScale = weight;
        s++;
    }
}

