using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SituationDisplay : MonoBehaviour
{
    public TextMeshProUGUI situationDisplayIdText;
    public TextMeshProUGUI situationDisplayTitleText;
    public TextMeshProUGUI situationDisplayDescriptionText;
    public TextMeshProUGUI situationDisplayQuestionText;
    public TextMeshProUGUI situationDisplayAnswer1Text;
    public TextMeshProUGUI situationDisplayAnswer2Text;
    public TextMeshProUGUI situationDisplayAnswer3Text;
    public TextMeshProUGUI situationDisplayAnswer4Text;

    public SituationModelSO situationDisplayData;

    public void LoadSituationDisaplyData (SituationModelSO situation) 
    {
        situation = situationDisplayData;
        situationDisplayIdText.text = situationDisplayData.id.ToString();
        situationDisplayTitleText.text = situationDisplayData.title;
    }

}
