using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using TMPro;
using Random = UnityEngine.Random;
using TMPro;

public class SituationGameManager : MonoBehaviour
{
    public TextMeshProUGUI situationDisplayId;
    public TextMeshProUGUI situationDisplayTitle;
    public TextMeshProUGUI situationDisplayDescription;
    public TextMeshProUGUI situationDisplayQuestion;
    public TextMeshProUGUI situationDisplayAnswer1;
    public TextMeshProUGUI situationDisplayAnswer2;
    public TextMeshProUGUI situationDisplayAnswer3;
    public TextMeshProUGUI situationDisplayAnswer4;






    private void Start()
    {
        situation_SO_To_Coupled = all_Situation_SO.ToList();
    }
    
    private void Update()
    {

    }
    
    public SituationModelSO[] all_Situation_SO;
    public Transform [] cardSlots;
    public bool [] availableCardSlots;
    // public string results;
    public List<SituationModelSO> situation_SO_Coupled;
    public List<SituationModelSO> situation_SO_Removed; 
    public List<SituationModelSO> situation_SO_To_Coupled;
    public GameObject situationCard;
    public GameObject cardInstantiated;
    public List <GameObject> cardInstantiated_List;
    public SituationModelSO randomSituation_SO;

    public void DrawCard () {

        Debug.Log("Situations left =: " + situation_SO_To_Coupled.Count);
        Debug.Log("Situations removed =: " + situation_SO_Removed.Count);

            for (int i = 0; i < cardSlots.Length; i++) {
                if (availableCardSlots[i] ==  true){
                    cardInstantiated = Instantiate(situationCard, new Vector2(0, 0), Quaternion.identity);
                    cardInstantiated_List.Add(cardInstantiated);

                    cardInstantiated.GetComponent<SituationCard>().LoadCardData(situation_SO_To_Coupled[Random.Range(0,situation_SO_To_Coupled.Count)]);
                    
                    SituationModelSO situation_SO_To_Be_Removed = cardInstantiated.GetComponent<SituationCard>().situationData;
                    situation_SO_To_Coupled.Remove(situation_SO_To_Be_Removed);
                    situation_SO_Removed.Add(situation_SO_To_Be_Removed);

                    cardInstantiated.transform.SetParent(cardSlots[i], false);
                    availableCardSlots[i] = false;

                    return;
                }
            }
    }     

    public void ShuffleCard () {

        if(situation_SO_Removed.Count>1) {
            foreach (SituationModelSO item in situation_SO_Removed){
                situation_SO_To_Coupled.Add(item);
            }
            foreach (GameObject item in cardInstantiated_List){
                Destroy(item);
            }
            cardInstantiated_List.Clear();
            situation_SO_Removed.Clear();
            
             for(int i = 0; i < availableCardSlots.Length ; i++) {
                availableCardSlots[i] = true;
            }

        }
        
    }

    public void DisplayCard () 
    {
        // if(situationDisplayId.text == "0") {
        //     situationDisplayId.text = this.GetComponent<SituationCard>().situationData.id.ToString();
        // }

        situationDisplayId.text = cardInstantiated_List[0].GetComponent<SituationCard>().situationData.id.ToString();
        situationDisplayTitle.text = cardInstantiated_List[0].GetComponent<SituationCard>().situationData.title;
        situationDisplayDescription.text = cardInstantiated_List[0].GetComponent<SituationCard>().situationData.description;
        situationDisplayQuestion.text = cardInstantiated_List[0].GetComponent<SituationCard>().situationData.question;
        situationDisplayAnswer1.text = cardInstantiated_List[0].GetComponent<SituationCard>().situationData.answer1;
        situationDisplayAnswer2.text = cardInstantiated_List[0].GetComponent<SituationCard>().situationData.answer2;
        situationDisplayAnswer3.text = cardInstantiated_List[0].GetComponent<SituationCard>().situationData.answer3;
        situationDisplayAnswer4.text = cardInstantiated_List[0].GetComponent<SituationCard>().situationData.answer4;
    }


    }


