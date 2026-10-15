using UnityEngine;

public class AirplaneFlight : MonoBehaviour
{
    public float speed = 20f;
    public float takeoffTime = 2f;
    public float climbSpeed = 6f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);

        if (timer > takeoffTime)
        {
            transform.Translate(Vector3.up * climbSpeed * Time.deltaTime, Space.World);
        }
    }
}