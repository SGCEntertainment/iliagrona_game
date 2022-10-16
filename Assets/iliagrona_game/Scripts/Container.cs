using UnityEngine;

public class Container : MonoBehaviour
{
    public int current;
    public int capacity;

    public void Add(int amount)
    {
        current += amount;
        if(current > capacity)
        {
            current = capacity;
        }

        UpdateItems();
    }

    public void Substract(int amount)
    {
        current -= amount;
        if(current < 0)
        {
            current = 0;
        }
        
        UpdateItems();
    }

    void UpdateItems()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i < current);
        }
    }
}
