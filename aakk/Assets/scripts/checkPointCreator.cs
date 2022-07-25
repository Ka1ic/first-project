using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPointCreator : MonoBehaviour
{
    [SerializeField] private Transform checkPoint = null;

    private Vector3 startPos;

    public void Start()
    {
        startPos = checkPoint.position;
    }

    public void newLvl(float x, float y)
    {
        checkPoint.position = new Vector3(x, y);

        startPos = checkPoint.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
            checkPoint.position = transform.position;

        if (Input.GetKey(KeyCode.R) && Input.GetKeyDown(KeyCode.E))
            checkPoint.position = startPos;
    }
}
