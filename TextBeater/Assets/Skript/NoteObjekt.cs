using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObjekt : MonoBehaviour
{
    
    public bool pressd;
    public KeyCode pressKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pressKey))
        {
            if (pressd)
            {
                
                gameObject.SetActive(false);

                GameManager.instance.NoteHit();

            }
            
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Activator")
        {

            pressd = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {

            pressd = false;
            GameManager.instance.NoteMisses();
        }
    }

}
