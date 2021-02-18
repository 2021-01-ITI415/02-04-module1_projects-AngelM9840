using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket_Prototype : MonoBehaviour
{
    [Header("Set Dynamically")]

    public Text scoreGT_2;
    public float speed = 2.5f;
    public float leftandRightEdge = 5.5f;
    public float chancetoChangeDirections = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO_2 = GameObject.Find("ScoreCounter_2");
        scoreGT_2 = scoreGO_2.GetComponent<Text>();
        scoreGT_2.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftandRightEdge ) {
            speed = Mathf.Abs(speed);
        } else if  (pos.x > leftandRightEdge ) {
            speed = -Mathf.Abs(speed);
        } 
    }

    void FixedUpdate() 
    {
        if ( Random.value < chancetoChangeDirections ) {
            speed *= -1;
        }
    }

    void OnCollisionEnter ( Collision coll )
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Projectile" ){
            Destroy( collidedWith);

            int score = int.Parse( scoreGT_2.text );
            score += 100;
            scoreGT_2.text = score.ToString();
            }
        }
}

