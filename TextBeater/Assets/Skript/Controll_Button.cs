using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll_Button : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite pressImage;
    public Sprite defaultImage;

    public KeyCode pressKey;

    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pressKey))
        {
            theSR.sprite = pressImage;
        }
        if (Input.GetKeyUp(pressKey))
        {
            theSR.sprite = defaultImage;
        }
        
    }
}
