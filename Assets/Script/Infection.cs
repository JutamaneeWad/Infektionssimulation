using Unity.VisualScripting;
using UnityEngine;

public class Infection : MonoBehaviour
{
    private SpriteRenderer sr;
    public int unitCondition;

    private float timer = 0.0f;
    private bool restart = false;

    // Initialize with RGB
    public Color Colorgreen = new Color(0.5f, 0.25f, 0.90f);
    public Color Coloryellow = new Color(255f, 249f, 90f);
    public Color Colorred = new Color(166f, 32f, 55f);
    public Color Colorblack = new Color(0f, 0f, 0f);

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
        if (unitCondition == 3)
        {
            sr.color = Colorblack;
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
        if(other.GetComponent<Infection>().unitCondition == 1)
        {

        }


     
    }
}
