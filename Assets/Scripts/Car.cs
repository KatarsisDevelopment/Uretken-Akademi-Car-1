using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float Speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Hor = Input.GetAxis("Horizontal") * Speed;
        float Ver = Input.GetAxis("Vertical") * Speed;
        transform.Translate(new Vector3(Hor, 0, Ver) * Time .deltaTime);
    }
}
