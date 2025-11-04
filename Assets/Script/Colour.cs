using UnityEngine;

public class Infection : MonoBehaviour
{
    private SpriteRenderer sr;
    public int unitCondition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(unitCondition == 0)
        {
            sr.color = Color.green;
        }
        if(unitCondition == 1)
        {
            sr.color = Color.yellow;
        }
        if (unitCondition == 2)
        {
            sr.color = Color.red;
        }
        if (unitCondition == 3)
        {
            sr.color = Color.black;
        }
        
    }
}
