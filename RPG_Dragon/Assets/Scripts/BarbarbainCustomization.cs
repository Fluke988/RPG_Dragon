using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarbainCustomization : MonoBehaviour
{
    public GameObject barbarainCharacter;
    public PlayerCharacter playerCharacterData;
    public Material[] barbarainSkins;
    //barbarain character clothes
    public GameObject cloth_01;
    public GameObject cloth_01_skin;
    public GameObject cloth_02;
    public GameObject cloth_02_skin;
    //barbarain character wepons
    public GameObject shield_01;
    public GameObject shield_02;
    //barbarain character shoulder
    public GameObject shoulder_01;
    public GameObject shoulder_02;
    //barbarain knee pad and leg plate
    public GameObject kneePad_rightLeg;
    public GameObject kneePad_leftLeg;
    public GameObject legPlate_rightLeg;
    public GameObject legPlate_leftLeg;
    //brabarain boots
    public GameObject Boots_01;
    public GameObject Boots_02;
    public bool rotateModle = false;
    // Start is called before the first frame update
    void Start()
    {
        //need to update playerCharacterData
        MyDisableGameObjects();
        Boots_01.SetActive(false);
        Boots_02.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //MyDisableGameObjects();
        if (Input.GetKeyDown(KeyCode.R))
        {
            rotateModle = !rotateModle;
        }
        if (rotateModle)
        {
            barbarainCharacter.transform.Rotate(new Vector3(0, 1, 0), 30f * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("Name");//using player prefs
        }
    }
    void MyDisableGameObjects()
    {
        cloth_01.SetActive(false);
        cloth_02.SetActive(false);
        cloth_01_skin.SetActive(false);
        cloth_02_skin.SetActive(false);
        shield_01.SetActive(false);
        shield_02.SetActive(false);
        shoulder_01.SetActive(false);
        shoulder_02.SetActive(false);
        kneePad_leftLeg.SetActive(false);
        kneePad_rightLeg.SetActive(false);
        legPlate_leftLeg.SetActive(false);
        legPlate_rightLeg.SetActive(false);
        //Boots_01.SetActive(false);
        //Boots_02.SetActive(false);
    }
}
