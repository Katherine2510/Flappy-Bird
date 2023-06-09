using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public float moveSpeed;
    public float oldPosition;
    private GameObject obj;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldPosition = 12;
        moveSpeed = 2;
        minY = 1;
        maxY = -1;

    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("ResetWall"))
        obj.transform.position = new Vector3(oldPosition, Random.Range(minY, maxY + 1),0);
    }

}