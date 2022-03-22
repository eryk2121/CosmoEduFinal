using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, Random.Range(-200,-1350));
    }

    
    void Update()
    {
        if (GetComponent<RectTransform>().localPosition.y < -1500)
        {
            Destroy(this.gameObject);
        }
    }

}
