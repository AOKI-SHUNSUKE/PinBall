using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCount : MonoBehaviour
{
    // Start is called before the first frame update
    Material myMaterial;
    private GameObject scoreText;


    private int score = 0;
    private int hit = 0;
    private int degree = 0;
    private int speed = 5;

    Color defaultColor = Color.white;

    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");

        

        this .scoreText.GetComponent<Text>().text = "Score:" +  this.score;



    }

    // Update is called once per frame
    void Update()
    {
       
        this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (tag == "SmallStarTag")
        {
            this.hit += 1;
        }
        else if (tag == "LargeStarTag")
        {
            this.hit += 2;

        }
        else if (tag == "LargeCloudTag")
        {
            this.hit += 4;
        }
        else if (tag == "SmallCloudTag")
        {
            this.hit += 3;
        }
        this.score = hit;
       
    }
}
