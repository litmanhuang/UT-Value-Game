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
    public TextMeshProUGUI situationDisplayTitle;
    public TextMeshProUGUI situationDisplayDescription;
    public TextMeshProUGUI situationDisplayQuestion;
    public TextMeshProUGUI situationDisplayAnswer1;
    public TextMeshProUGUI situationDisplayAnswer2;
    public TextMeshProUGUI situationDisplayAnswer3;
    public TextMeshProUGUI situationDisplayAnswer4;

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
        situationDisplayId.text = situationDrawn[0].id.ToString();
        situationDisplayTitle.text = situationDrawn[0].title;
        situationDisplayDescription.text = situationDrawn[0].description;
        situationDisplayQuestion.text = situationDrawn[0].question;
        situationDisplayAnswer1.text = situationDrawn[0].answer1;
        situationDisplayAnswer2.text = situationDrawn[0].answer2;
        situationDisplayAnswer3.text = situationDrawn[0].answer3;
        situationDisplayAnswer4.text = situationDrawn[0].answer4;
    }


    }


