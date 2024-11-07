using UnityEngine;

public class MUDscript : MonoBehaviour
{
    public float mud = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            mud += 1f;
            Debug.Log("MUDscript" + mud);
        }
    }
}
