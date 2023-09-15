using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    
    
    int blockRed_Health = 5;
    int blockGreen_Health = 1;
    int blockPink_Health = 4;
    int blockblue_Health = 0;
    int blockYellow_Health = 3;

    int redScore = 6;
    int greenScore = 2;
    int pinkScore = 5;
    int blueScore = 1;
    int yellowScore = 4;

    int test;



    float color = 1f;

    public Score score;

    SpriteRenderer ren;

    private void Start()
    {
        



        ren = GetComponent<SpriteRenderer>();
        ren.color = new Color(color, color, color);

        

        


    }

    void Update()
    {

        
        


    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        

        string blocks = gameObject.tag;


        

        switch (blocks)
        {
            case "block_red":
                BlockHit(blockRed_Health, redScore);
                break;
            case "block_green":

                BlockHit(blockGreen_Health, greenScore);
                break;
            case "block_pink":

                BlockHit(blockPink_Health, pinkScore);

                break;
            case "block_blue":

                BlockHit(blockblue_Health, blueScore);
                break;

            case "block_yellow":

                BlockHit(blockYellow_Health, yellowScore);

                break;

            case "EndWall":
                ren.color = Color.red;
                
                score.GameOver();
                break;
        }
        ren.color *= new Color(0.8f, 0.8f, 0.8f, 255);




        //if (gameObject.name == "block_red")
        //{
        //    Debug.Log("REEEEED");
        //}
        //Destroy(gameObject);
    }

    private void BlockHit(int health, int score_)
    {
        health--;
        color = color / health;
        if (health < 0)
        {
            score.winpoints(score_);
            Destroy(gameObject);

        }
    }



}
