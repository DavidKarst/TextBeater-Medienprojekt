using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFall : MonoBehaviour
{
    public float beatTempo;
    public bool start;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!start)
        {
            //if(Input.anyKeyDown)
            //{
            //    start = true;
            //}
        } else
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
        
    }
}
