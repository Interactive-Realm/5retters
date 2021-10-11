using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{

    public float bev�gelsesFart = 5f;
    float bev�gelseX;
    float bev�gelseY;
    public List<GameObject> inRange;


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
        transform.Translate(newPosition * bev�gelsesFart * Time.deltaTime, Space.World);
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

    private void OnTriggerEnter(Collider other)
    {
        
        if(!inRange.Contains(other.gameObject))
        {
            if (other.gameObject.CompareTag("Workstation"))
            {
                inRange.Add(other.gameObject);
                print(other + "in range");

            }
        }  
               
    }

    private void OnTriggerExit(Collider other)
    {
        if(inRange.Contains(other.gameObject))
        { 
            inRange.Remove(other.gameObject);
            print(other + "out of range");
        }

    }
}
