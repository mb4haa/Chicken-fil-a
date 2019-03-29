using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10;
    int lives = 2;
    float timeLeft = 300;
    //COLLECTED
    string[] collected = new string[8];
    int collectedIndex = 0;
    //RECIPES
    string[] originalFil = new string[] { "BOTTOM BUN", "LETTUCE", "CHICKEN", "HONEY MUSTARD", "CHICKEN", "CHEESE SAUCE", "TOP BUN" };
    string[] juicyLucy = new string[] { "BOTTOM BUN", "RANCH", "LETTUCE", "CHICKEN", "CHEESE STICKS", "TOP BUN" };
    string[] americanFil = new string[] { "BOTTOM BUN", "LETTUCE", "CHEESE", "CHICKEN", "AMERICAN SAUCE", "BEEF BACON", "TOP BUN" };
    string[] mexicanFil = new string[] { "BOTTOM BUN", "LETTUCE", "SPICY MAYO", "CHICKEN", "COLORED PEPPERS", "NACHOS", "CHEESE", "TOP BUN" };
    string[] italianFil = new string[] { "BOTTOM BUN", "LETTUCE", "RANCH", "CHICKEN", "MARINARA", "PEPPERONI", "MOZZARELLA", "TOP BUN" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if ( timeLeft < 0 )
        {
         GameOver();
        }
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
         if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * Time.deltaTime * speed);
         if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
             transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("Ingredient")){
            string name = col.gameObject.GetComponent<IngredientHandler>().name;
            collected[collectedIndex] = name;
            collectedIndex++;
            
        }


    }
}
