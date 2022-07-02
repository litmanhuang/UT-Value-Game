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

    private SituationModelSO situation;

    public void PopulateSituationDisplay(int situationCardIndex)
    {
        situationDisplayIdText.text = situation.id.ToString();
        situationDisplayTitleText.text = situation.title;
        situationDisplayDescriptionText.text = situation.description;
        situationDisplayQuestionText.text = situation.question;
        situationDisplayAnswer1Text.text = situation.answer1;
        situationDisplayAnswer2Text.text = situation.answer2;
        situationDisplayAnswer3Text.text = situation.answer3;
        situationDisplayAnswer4Text.text = situation.answer4;
    }

}
