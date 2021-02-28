using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObjekt : MonoBehaviour
{
    
    public bool pressd;
    public KeyCode pressKey;

    public GameObject HitEffekt, goodEffect, perfectEffekt, missEffekt;




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

                //GameManager.instance.NoteHit();
            if(Mathf.Abs(transform.position.y) > 0.25f)
            {
                    Debug.Log("Normal HIT");
                    GameManager.instance.NormalHit();
                    Instantiate(HitEffekt, transform.position, HitEffekt.transform.rotation);
                } else if(Mathf.Abs( transform.position.y) > 0.05f)
            {
                    Debug.Log("Good HIT");
                    GameManager.instance.GoodHit();
                    Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
                }
                else
                {
                    Debug.Log("Perfekt HIT");
                    GameManager.instance.PerfectHit();
                    Instantiate(perfectEffekt, transform.position, perfectEffekt.transform.rotation);
                }

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
            Instantiate(missEffekt, transform.position, missEffekt.transform.rotation);
        }
    }

}
