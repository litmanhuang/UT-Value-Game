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

 

    public List<GameObject> deck;




 
    

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
            
             for(int i = 0; i < availableCardSlots.Length ; i++) {
                availableCardSlots[i] = true;
            }

        }
        
    }



        // //instantiating the prefab
        // GameObject mySituationCard = Instantiate(situationCard, new Vector2(0, 0), Quaternion.identity);
        // //calling the LoadCardData to retrieve data from scriptable object
        // mySituationCard.GetComponent<SituationCard>().LoadCardData(All_Situation_SO[Random.Range(0,5)]);
        // //store the scritable object into the list
        // situationDrawn.Add(mySituationCard.GetComponent<SituationCard>().situationData);

        // foreach (var item in situationDrawn){
        //     results += item.id.ToString() + ", "; 
        // }
        
        // Debug.Log(results);
  
        // for  (int i = 0; i < cardSlots.Length; i++){
        //     if (availableCardSlots[i] == true){
        //     mySituationCard.transform.SetParent(cardSlots[i], false);
        //     availableCardSlots[i]=false;
        //     return;
        //     }
        // }
        

    // public void DisplaySituation () 
    // {
    //     situationDisplayId.text = situationDrawn[0].id.ToString();
    //     situationDisplayTitle.text = situationDrawn[0].title;
    //     situationDisplayDescription.text = situationDrawn[0].description;
    //     situationDisplayQuestion.text = situationDrawn[0].question;
    //     situationDisplayAnswer1.text = situationDrawn[0].answer1;
    //     situationDisplayAnswer2.text = situationDrawn[0].answer2;
    //     situationDisplayAnswer3.text = situationDrawn[0].answer3;
    //     situationDisplayAnswer4.text = situationDrawn[0].answer4;
    // }


    }


