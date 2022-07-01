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

    public SituationModelSO[] situations;

    public void PopulateSituationDisplay(int situationCardIndex)
    {
        situationDisplayIdText.text = situations[situationCardIndex].id.ToString();
        situationDisplayTitleText.text = situations[situationCardIndex].title;
        situationDisplayDescriptionText.text = situations[situationCardIndex].description;
        situationDisplayQuestionText.text = situations[situationCardIndex].question;
        situationDisplayAnswer1Text.text = situations[situationCardIndex].answer1;
        situationDisplayAnswer2Text.text = situations[situationCardIndex].answer2;
        situationDisplayAnswer3Text.text = situations[situationCardIndex].answer3;
        situationDisplayAnswer4Text.text = situations[situationCardIndex].answer4;
    }

}
