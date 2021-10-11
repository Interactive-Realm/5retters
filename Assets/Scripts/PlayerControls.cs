using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{

    public float moveSpeed = 5f;
    float bev�gelseX;
    float bev�gelseY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(bev�gelseX, 0.0f, bev�gelseY);

        // Look Towards
        transform.LookAt(newPosition + transform.position);


        // Move
        transform.Translate(newPosition * moveSpeed * Time.deltaTime, Space.World);
    }

    void OnMove(InputValue bev�gelseV�rdi)
    {

        Vector2 bev�gelsesVector = bev�gelseV�rdi.Get<Vector2>();

         bev�gelseX = bev�gelsesVector.x;
         bev�gelseY = bev�gelsesVector.y;




    }


    void OnInteract()
    {

        print("HI");

    }

    void OnB�vle()
    {

        print("B�vler");

    }
}
