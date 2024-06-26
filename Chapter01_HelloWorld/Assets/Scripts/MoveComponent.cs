using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    public Vector3 dirVec;
    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        dirVec = new Vector3(x, y, 0);

        transform.position += dirVec * moveSpeed * Time.deltaTime;

        /*Debug.Log($"x: {x}");
        Debug.Log($"y: {y}");
        Debug.Log($"Time.deltaTime: {Time.deltaTime}");*/
    }
}
