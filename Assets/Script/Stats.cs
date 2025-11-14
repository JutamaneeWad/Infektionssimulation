using UnityEngine;

public class Stats : MonoBehaviour
{
    //Deklarera variabler för statistik
    
    public static int FriskCount = 0;
    public static int SjukCount = 0;
    public static int ImmunCount = 0;
    public static int DeadCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
