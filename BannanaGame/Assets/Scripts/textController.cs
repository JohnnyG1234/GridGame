using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textController : MonoBehaviour
{
    [SerializeField] private Text textRefference;
    [SerializeField] private playerMovement player;
    [SerializeField] private GridManeger grid;

    private Vector2Int firstTrigger = new Vector2Int(3, 1);

    [TextArea(5, 15)]
    public string[] text;

    private void Start()
    {
        textRefference.text = text[0];
    }

    private void Update()
    {
        if (player.currentTile == grid.GetTile(firstTrigger))
        {
            textRefference.text = text[1];
        }
    }
}
