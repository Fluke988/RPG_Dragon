using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    public GameObject infoText;
    public GameObject diaglogText;
    bool tempInfotexactive = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //if (tempInfotexactive == false)
            {
                if (Input.GetKeyDown(KeyCode.K))
                {
                    //other.gameObject.GetComponent<Player>().dialogNumber = 1;
                    diaglogText.SetActive(true);
                    infoText.SetActive(false);
                    //tempInfotexactive = true;
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        infoText.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        infoText.SetActive(false);
        //diaglogText.SetActive(false);
    }
}
