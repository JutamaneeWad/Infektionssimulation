using UnityEngine;

public class WalkingMotions : MonoBehaviour
{ 
    public Vector3 Target;
    public string condition = "Healthy";
    Color human_color = Color.green;
    SpriteRenderer human_Sprite;

    public GameObject projectile;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

    Color greenColr = new Color(203f, 255f, 90f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        human_Sprite = GetComponent<SpriteRenderer>();
        human_Sprite.color = Color.green;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target, 3f * Time.deltaTime);

        if (transform.position == Target )
        {
            Target = new Vector3(Random.Range(-11,11), Random.Range(-4,4), 0);
        }

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time; 
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Human")
        {

        }
        Debug.Log("I collided with" + other);


    }
}
