using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real-world seconds it takes to complete one full day.")]
    [Min(1f)]
    public float secondsPerDay = 120f;

    void Update()
    {
        // Calculate how many degrees the sun should rotate per second.
        float degreesPerSecond = 360f / secondsPerDay;

        // Rotate the Directional Light around the X axis.
        transform.Rotate(Vector3.right, degreesPerSecond * Time.deltaTime);
    }
}