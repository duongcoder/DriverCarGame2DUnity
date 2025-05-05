using UnityEngine;

public class SettingCar : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.2f;

    [SerializeField] float steerSpeed = 0.2f;

    [SerializeField] float boostSpeed = 20f;
    
    [SerializeField] float normalSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float changeSteer = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float changeMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(0, changeMove, 0);
        transform.Rotate(0, 0, -changeSteer);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = normalSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}
