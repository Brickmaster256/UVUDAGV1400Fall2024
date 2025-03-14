using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCollectables : MonoBehaviour
{
    public void HideObject()
    {
        this.gameObject.transform.position = new Vector3(0,-100,0);
   }

}
