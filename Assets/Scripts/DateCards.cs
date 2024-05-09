using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateCards : MonoBehaviour
{
    [SerializeField]
    private GameObject[] allDateCards;
    private int tempCounterItem = 0;
    private int tempCounterKnowledge = 0;

    // Start is called before the first frame update
    void Awake()
    {
        allDateCards = GameObject.FindGameObjectsWithTag("Card");

        for(int i = 0; i < allDateCards.Length; i++)
        {
            allDateCards[i].SetActive(false);
        }

    }

    void Start()
    {
        for (int num = 0; num < Cards.dateCards.Count; num++)
        {
            //item card numbers
            if (Cards.dateCards[num] <= 10)
            {
                allDateCards[Cards.dateCards[num] - 1].SetActive(true);
                allDateCards[Cards.dateCards[num] - 1].GetComponent<RectTransform>().localPosition = new Vector3(tempCounterItem * 150 + 100, -100, 0);
                tempCounterItem++;
            }
            //Knowledge card numbers
            else if(Cards.dateCards[num] > 10)
            {
                allDateCards[Cards.dateCards[num] - 1].SetActive(true);
                allDateCards[Cards.dateCards[num] - 1].GetComponent<RectTransform>().localPosition = new Vector3(tempCounterKnowledge * 150 + 100, -100, 0);
                tempCounterKnowledge++;
            }
        }
    }

}
