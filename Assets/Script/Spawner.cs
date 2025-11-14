using JetBrains.Annotations;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject Spawner;
    public GameObject stats;
    int diceRoll;
    public int numberOfHumans;
    public int initialDiseaseChance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //
        for (var i = 0; i < numberOfHumans; i++)
        {
            GameObject humanInstance = Instantiate(Spawner, new Vector3(i * 0, -5f, 0), Quaternion.identity);

            diceRoll = Random.Range(0, 100);

            if (diceRoll < initialDiseaseChance)
            {
                humanInstance.GetComponent<Infection>().unitCondition = 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
