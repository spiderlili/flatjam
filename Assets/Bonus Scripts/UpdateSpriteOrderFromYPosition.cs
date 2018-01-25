using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UpdateSpriteOrderFromYPosition : MonoBehaviour {

    SpriteRenderer sprite;
    public float orderMultiplication = -10;
    public Transform thisObjectsGroundPosition;

	void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        if (thisObjectsGroundPosition == null)
            thisObjectsGroundPosition = transform;
    }
	
	
	void Update ()
    {
        if (thisObjectsGroundPosition == null)
            Awake();


        sprite.sortingOrder = Mathf.RoundToInt(thisObjectsGroundPosition.position.y * orderMultiplication);
    }
}
