using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Random = System.Random;

public class SituationCard : MonoBehaviour
{
    public TextMeshProUGUI situationCardIdText;
    public TextMeshProUGUI situationCardTitleText;

    private SituationModelSO situation;
    
    public  void LoadSituationCardData(SituationModelSO situationData)
    {
        situation = situationData;
        situationCardIdText.text = situation.id.ToString(); 
        situationCardTitleText.text = situation.title;
        
    }
}
