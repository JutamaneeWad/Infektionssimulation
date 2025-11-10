using UnityEngine;

public class Infection : MonoBehaviour
{
    private SpriteRenderer sr;
    public int unitCondition;

    // Initialize with RGB
    public Color Colorgreen = new Color(50f, 25f, 90f);
    public Color Coloryellow = new Color(255f, 249f, 90f);
    public Color Colorred = new Color(166f, 32f, 55f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        int diceRoll = Random.Range(0, 50);

        if (diceRoll < 10)
        {
            unitCondition = 1;
        }
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
            sr.color = Colorred;
        }
        if (unitCondition == 3)
        {
            sr.color = Color.black;
        }
        
    }
}
