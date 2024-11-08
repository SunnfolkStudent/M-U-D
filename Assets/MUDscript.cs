using UnityEngine;
using FMODUnity;

public class MUDscript : MonoBehaviour
{
    public float mud = 0;

    public float start = 1;
    
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(("space")) && start == 1)
        {   
            _animator.Play("cleanDirt");
            Debug.Log("MUDING");
            start = 0;
        }
        
        else if (Input.GetKeyDown("space") && (mud == 1))
        {
            _animator.Play("dirtyDirt");
            Debug.Log("MUDscript" + mud);
        }
        
        if (Input.GetKeyDown("m"))
        {
            Debug.Log("MUDscript" + mud);
            Splash();
        }
    }

    public void MUD()
    {
        mud = 0;
        RuntimeManager.PlayOneShot("event:/Digg Mud Right");
        RuntimeManager.PlayOneShot("event:/Digg Mud Left");
    }

    public void Splash()
    {
        RuntimeManager.PlayOneShot("event:/Dropp Mud Right");
        RuntimeManager.PlayOneShot("event:/Dropp Mud Left");
    }

    public void Mudreaddy()
    {
        mud = 1;
        _animator.Play("dirtyIdle");
    }
}
