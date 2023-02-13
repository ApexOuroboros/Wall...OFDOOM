using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMove : MonoBehaviour
{
    private float dist;
    public int speed = 10;
    private bool isMove;
    public GameObject Wall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(isMove == true)
        {
            Wall.transform.position += transform.right * speed * Time.deltaTime;
        }
    }

}
