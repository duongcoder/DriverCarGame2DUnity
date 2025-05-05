using System;
using UnityEngine;

public class Shipping : MonoBehaviour
{
    [SerializeField] float delayDestroy = 0.5f;

    bool hasBox = false;

    [SerializeField] Color32 boxColor = new Color32(1, 1, 1, 1);

    [SerializeField] Color32 noboxColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "CargoBox" && !hasBox)
        {
            Debug.Log("Da lay hang");
            hasBox = true;
            Destroy(other.gameObject, delayDestroy);

            spriteRenderer.color = boxColor;
        }

        if (other.tag == "Location" && hasBox)
        {
            Debug.Log("Da giao hang");
            hasBox = false;

            spriteRenderer.color = noboxColor;
        }
    }
}
