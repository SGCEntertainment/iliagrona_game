using UnityEngine;
using UnityEngine.UI;

public class DropBtn : MonoBehaviour
{
    [SerializeField] Container from;
    [SerializeField] Container to;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            GameManager.Instance.Transfer(from, to);
        });
    }
}
