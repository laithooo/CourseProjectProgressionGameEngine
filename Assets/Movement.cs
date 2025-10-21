using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    [SerializeField] float rotationX = 5f;
    [SerializeField] private Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        TimeManager.Instance.SetTime(120f); 
        TimeManager.Instance.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moving = new Vector3 (horizontal,0,vertical);

        transform.Translate( moving * speed * Time.deltaTime);

        if (vertical != 0)
        {
            animator.SetBool("isMoving", true);

        }

     
        else
        {
            animator.SetBool("isMoving", false);
        }

        float rotateCharacterX = Input.GetAxis("Mouse X") * rotationX;
        

        Vector3 Rotate =  new Vector3 (0, rotateCharacterX, 0);

        transform.Rotate(Rotate);

    }
}
