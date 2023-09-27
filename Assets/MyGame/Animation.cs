using System.Collections;
using UnityEngine;


public class Animation : MonoBehaviour
{
    public GameObject[] segments; 
    public float animationDelay = 0.5f; 

    private int segmentNR = 0; 

    private void Start()
    {
        
        foreach (GameObject segment in segments)
        {
            segment.SetActive(false);
        }
    }

    public void StartAnimation()
    {
       
        StartCoroutine(Segmentanimation());
    }

    IEnumerator Segmentanimation()
    {
        
        foreach (GameObject segment in segments)
        {
            segment.SetActive(false);
        }

        
        while (segmentNR < segments.Length)
        {
            segments[segmentNR].SetActive(true);
            yield return new WaitForSeconds(animationDelay);
           segmentNR++;
        }

        
        segmentNR = 0;
    }
}