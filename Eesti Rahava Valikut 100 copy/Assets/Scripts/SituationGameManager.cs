using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using TMPro;
using Random = System.Random;

public class SituationGameManager : MonoBehaviour
{
    public GameObject situationCard;

    public List<GameObject> deck;

    public Transform [] cardSlots;

    public bool [] availableCardSlots;

    public SituationModelSO[] SituationData;
    
    private void Start()
    {
   
    }
    
    private void Update()
    {


    }
    
    public void DrawSituationCard () 
    {
            GameObject mySituationCard = Instantiate(situationCard, new Vector2(0, 0), Quaternion.identity);
            mySituationCard.GetComponent<SituationCard>().LoadSituationCardData(SituationData[1]);
            mySituationCard.transform.SetParent(cardSlots[0], false);
    }

    }

