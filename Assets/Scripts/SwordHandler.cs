using System.Collections;
using UnityEngine;

public class SwordHandler : MonoBehaviour
{
    public float speed = 1;
    public float angle = 45;
    public GameObject swordPivot;

    private void Awake()
    {
        swordPivot.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Swing());
        }
    }

    IEnumerator Swing()
    {
        swordPivot.SetActive(true);
        
        float startTime = Time.time;
        float endTime = startTime + 1/speed;
        while (Time.time < endTime)
        {
            float t = (Time.time - startTime) / (endTime - startTime);
            swordPivot.transform.localRotation = Quaternion.Euler(0, 0, Mathf.Lerp(-angle/2, angle/2, t));
            yield return null;
        }
        
        swordPivot.SetActive(false);
    }
}
