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

    public SituationModelSO situationData;
    
    public  void LoadSituationCardData(SituationModelSO situation)
    {
        situationData = situation;
        situationCardIdText.text = situation.id.ToString(); 
        situationCardTitleText.text = situation.title;
        
    }
}
