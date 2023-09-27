
using UnityEngine;
using UnityEngine.UI;

public class NumberChange : MonoBehaviour
{
    public GameObject[] segments; 
    public Button[] numberButtons; 

    private void Start()
    {
       
        foreach (GameObject segment in segments)
        {
            segment.SetActive(false);
        }

      
        for (int i = 0; i < numberButtons.Length; i++)
        {
            int number = i; 
            numberButtons[i].onClick.AddListener(() => SetSegmentsForNumber(number));
        }
    }

    void SetSegmentsForNumber(int number)
    {
        
        foreach (GameObject segment in segments)
        {
            segment.SetActive(false);
        }

        
        switch (number)
        {
            case 0:
                segments[0].SetActive(true);
                segments[1].SetActive(true);
                segments[2].SetActive(true);
                segments[3].SetActive(false);
                segments[4].SetActive(true);
                segments[5].SetActive(true);
                segments[6].SetActive(true);
                break;
            case 1:
                segments[0].SetActive(false);
                segments[1].SetActive(false);
                segments[2].SetActive(true);
                segments[3].SetActive(false);
                segments[4].SetActive(false);
                segments[5].SetActive(true);
                segments[6].SetActive(false);
                break;
            case 2:
                segments[0].SetActive(false);
                segments[1].SetActive(true);
                segments[2].SetActive(true);
                segments[3].SetActive(true);
                segments[4].SetActive(true);
                segments[5].SetActive(false);
                segments[6].SetActive(true);
                break;
            case 3:
                segments[0].SetActive(false);
                segments[1].SetActive(true);
                segments[2].SetActive(true);
                segments[3].SetActive(true);
                segments[4].SetActive(false);
                segments[5].SetActive(true);
                segments[6].SetActive(true);
                break;
            case 4:
                segments[0].SetActive(true);
                segments[1].SetActive(false);
                segments[2].SetActive(true);
                segments[3].SetActive(true);
                segments[4].SetActive(false);
                segments[5].SetActive(true);
                segments[6].SetActive(false);
                break;
            case 5:
                segments[0].SetActive(true);
                segments[1].SetActive(true);
                segments[2].SetActive(false);
                segments[3].SetActive(true);
                segments[4].SetActive(false);
                segments[5].SetActive(true);
                segments[6].SetActive(true);
                break;
            case 6:
                segments[0].SetActive(true);
                segments[1].SetActive(true);
                segments[2].SetActive(false);
                segments[3].SetActive(true);
                segments[4].SetActive(true);
                segments[5].SetActive(true);
                segments[6].SetActive(true);
                break;
            case 7:
                segments[0].SetActive(false);
                segments[1].SetActive(true);
                segments[2].SetActive(true);
                segments[3].SetActive(false);
                segments[4].SetActive(false);
                segments[5].SetActive(true);
                segments[6].SetActive(false);
                break;
            case 8:
                segments[0].SetActive(true);
                segments[1].SetActive(true);
                segments[2].SetActive(true);
                segments[3].SetActive(true);
                segments[4].SetActive(true);
                segments[5].SetActive(true);
                segments[6].SetActive(true);
                break;
            case 9:
                segments[0].SetActive(true);
                segments[1].SetActive(true);
                segments[2].SetActive(true);
                segments[3].SetActive(true);
                segments[4].SetActive(false);
                segments[5].SetActive(true);
                segments[6].SetActive(true);
                break;

            default:
                break;
        }
    }
}