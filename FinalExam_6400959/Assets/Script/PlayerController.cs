using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1;
    Rigidbody2D rigidbody;
    int Bonus;
    [SerializeField]private Text BonusText;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(horizontal * Time.deltaTime*speed, 0,0);
        transform.Translate(0, vertical * Time.deltaTime*speed, 0);

        //Rotation
        //transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);




    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Point")
        {
            //print("hit");
            Destroy(collision.gameObject);
            Bonus += 5;
            BonusText.text = "Bonus : " + Bonus.ToString();

        }

       
    }

}
