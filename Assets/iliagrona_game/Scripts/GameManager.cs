using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if(!instance)
            {
                instance = FindObjectOfType<GameManager>();
            }

            return instance;
        }
    }

    [Space(10)]
    [SerializeField] Container left;
    [SerializeField] Container middle;
    [SerializeField] Container right;

    [Space(10)]
    [SerializeField] GameObject winGO;

    private void Start()
    {
        ResetGame();
    }

    private void Update()
    {
        if(middle.current == right.current)
        {
            winGO.SetActive(true);
        }
    }

    private void ResetGame()
    {
        left.Add(0);
        middle.Add(0);
        right.Add(8);
    }

    public void Transfer(Container from, Container to)
    {
        int targetFreeCount = to.capacity - to.current;
        int canTransferCount = from.current;

        int totalTransferCount = targetFreeCount > canTransferCount ? from.current : targetFreeCount;

        from.Substract(totalTransferCount);
        to.Add(totalTransferCount);
    }
}