using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCard : MonoBehaviour
{
    [SerializeField] Text finalScore;
    // Start is called before the first frame update
    void Start()
    {
        finalScore.text = "Orbs Collected : ";
        Debug.Log(BossController.a);
    }

    // Update is called once per frame
    void Update()
    {
        finalScore.text = "Orbs Collected : "+BossController.a.ToString() + "                                              Distance: " + (BossController.c);
    }
}
