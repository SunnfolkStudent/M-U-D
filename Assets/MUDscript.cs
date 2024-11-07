using UnityEngine;
using FMODUnity;

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
            RuntimeManager.PlayOneShot("event:/Digg Mud Right");
            RuntimeManager.PlayOneShot("event:/Digg Mud Left");
        }
    }

    public void MUD()
    {
        
    }
}
