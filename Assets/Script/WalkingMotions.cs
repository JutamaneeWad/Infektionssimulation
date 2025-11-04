using UnityEngine;

public class WalkingMotions : MonoBehaviour
{ 
    public Vector3 Target;
    public string condition = "Healthy";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target, 3f * Time.deltaTime);

        if (transform.position == Target )
        {
            Target = new Vector3(Random.Range(-8,8), Random.Range(-4,4), 0);
        }
    }
}
