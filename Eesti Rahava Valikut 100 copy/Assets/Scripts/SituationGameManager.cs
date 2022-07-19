using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using TMPro;
using Random = UnityEngine.Random;
using TMPro;

public class SituationGameManager : MonoBehaviour
{
    public GameObject situationCard;

    public TextMeshProUGUI situationDisplayId;

    public List<SituationModelSO> situationDrawn;

    public List<GameObject> deck;


    public Transform [] cardSlots;


    public SituationModelSO[] SituationData;
    

    private void Start()
    {
   
    }
    
    private void Update()
    {

    }
    
    public void DrawSituationCard () 
    {
        //instantiating the prefab
        GameObject mySituationCard = Instantiate(situationCard, new Vector2(0, 0), Quaternion.identity);
        //calling the LoadSituationCardData to retrieve data from scriptable object
        mySituationCard.GetComponent<SituationCard>().LoadSituationCardData(SituationData[Random.Range(0,5)]);
        //store the scritable object into the list
        situationDrawn.Add(mySituationCard.GetComponent<SituationCard>().situationData);
        mySituationCard.transform.SetParent(cardSlots[0], false);
    }
    public void DisplaySituation () 
    {
        Debug.Log(situationDrawn[0].id.ToString());
        situationDisplayId.text = situationDrawn[0].id.ToString();
    }


    }


