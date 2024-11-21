using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    
    [SerializeField] private LayerMask player;
    [SerializeField] private Transform hands;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool collectableInRange = Physics.CheckSphere(transform.position, 5f, player);

        
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.parent = hands.transform;
            }
        

        


        if (Input.GetKeyDown(KeyCode.E) && transform.parent != null) 
        {
            transform.parent = null; 
        }
    }
}
