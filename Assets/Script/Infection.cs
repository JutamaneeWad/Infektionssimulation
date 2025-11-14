using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Infection : MonoBehaviour
{
    private SpriteRenderer sr;
    public int unitCondition;

    // Initialize with RGB
    public Color Colorgreen = new Color(0.5f, 0.25f, 0.90f);
    public Color Coloryellow = new Color(255f, 249f, 90f);
    public Color Colorred = new Color(166f, 32f, 55f);
    public Color Colorblack = new Color(0f, 0f, 0f);

    //Skapa referens till "Stats"-spelobjektet

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //Frisk
        if(unitCondition == 0)
        {
            sr.color = Colorgreen;
        }

        //Sjuk
        if(unitCondition == 1)
        {
            sr.color = Coloryellow;
        }

        //Immun
        if (unitCondition == 2)
        {
            sr.color = Colorred;
        }

        //Död
        if (unitCondition == 3)
        {
            sr.color = Colorblack;

            //är död!
            //Prata med WalkingMotions och säg att humanSpeed ska bli 0! [Done]
            GetComponent<WalkingMotions>().humanSpeed = 0;
        }
    }
  
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Human")
        {
            //ska va tomt
        }
        Debug.Log("I collided with" + other);

        //Jag kollar om den jag kolliderar med har unit condition 1! (om den är sjuk)
        if(other.GetComponent<Infection>().unitCondition == 1 && unitCondition == 0)
        {
            int diceroll = Random.Range(0, 100);
            if (diceroll < 50)
            {
                unitCondition = 1;
                //Säg till stats att plussa på "Sick" med ett

                StartCoroutine(Countdown());
            }
        }


     
    }

    IEnumerator Countdown()
    {
        int diceroll = Random.Range(3, 10);
        yield return new WaitForSeconds(diceroll);

        diceroll = Random.Range(0, 100);
        if (diceroll < 50)
        {
            //Säg till stats att plussa på "Immune" med ett
            unitCondition = 2;
        }

        else
        {
            //Säg till stats att plussa på "Dead" med ett
            unitCondition = 3;
        }
        yield return null;


    }
}
