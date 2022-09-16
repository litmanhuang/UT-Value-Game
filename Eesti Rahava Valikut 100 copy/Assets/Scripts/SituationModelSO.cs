using UnityEngine;

[CreateAssetMenu(fileName = "Situation Card", menuName = "ScriptableObjects/New Situation Card")]
public class SituationModelSO : ScriptableObject {
    
    public int id;
    public string title;
    public string description;
    public string question;
    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;
    public bool hasBeenCoupled;
    
    
}



