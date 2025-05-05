
using System;
using UnityEngine;

public class Driving : MonoBehaviour
{

    [SerializeField] float moveSpeed = 0.2f;

    [SerializeField] float steerSpeed = 0.2f;

    //[SerializeField] float delayDestroy = 0.5f;

    //bool hasBox = false;

    //[SerializeField] Color32 boxColor = new Color32(1, 1, 1, 1);
    
    //[SerializeField] Color32 noboxColor = new Color32(1, 1, 1, 1);

    //SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float changeSteer = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float changeMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(0, changeMove, 0);
        transform.Rotate(0, 0, -changeSteer);
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.tag == "CargoBox" && !hasBox)
    //    {
    //        Debug.Log("Da lay hang");
    //        hasBox = true;
    //        Destroy(other.gameObject, delayDestroy);

    //        spriteRenderer.color = boxColor;
    //    }

    //    if (other.tag == "Location" && hasBox)
    //    {
    //        Debug.Log("Da giao hang");
    //        hasBox = false;

    //        spriteRenderer.color = noboxColor;
    //    }
    //}
}
