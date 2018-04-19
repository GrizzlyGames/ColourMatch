using UnityEngine;

public class Tile_Class : MonoBehaviour
{

    public bool isActive;
    public int colorCode;

    private SpriteRenderer spriteRenderer;
    private GameObject highlightGO;

    private void Awake()
    {
        if (GetComponent<SpriteRenderer>())
            spriteRenderer = GetComponent<SpriteRenderer>();
        else
            Debug.Log(this.name + " does not have a SpriteRenderer Component.");

        if (this.transform.GetChild(0))
            highlightGO = this.transform.GetChild(0).transform.gameObject;
        else
            Debug.Log(this.name + " unable to find child gameobject highlight object.");

    }

    public int RandomColor()
    {
        /*
        0 = Red
        1 = Orange
        2 = Yellow
        3 = Green
        4 = Blue
        5 = Violet     
         */

        int colorCode = Random.Range(0, 5);
        return (colorCode);
    }
    public void SetColor(int colorCode)
    {
        switch (colorCode)
        {
            case 0:
                spriteRenderer.color = Color.red;
                break;
            case 1:
                spriteRenderer.color = new Color32(255, 165,0,255); // Orange
                break;
            case 2:
                spriteRenderer.color = Color.yellow;
                break;
            case 3:
                spriteRenderer.color = Color.green;
                break;
            case 4:
                spriteRenderer.color = Color.blue;
                break;
            default:
                spriteRenderer.color = new Color32(165, 0, 255, 255); // Violet
                break;
        }
    }

    public void SetBackgroundHighlight(bool state)
    {
            highlightGO.SetActive(state);
    }

    private void OnMouseDown()
    {
        if(Game_Class.instance.primaryTile != this.gameObject)
        {
            Game_Class.instance.secondaryTile = Game_Class.instance.primaryTile;
            if (Game_Class.instance.primaryTile != null && Game_Class.instance.primaryTile.GetComponent<Tile_Class>() != null)
                Game_Class.instance.primaryTile.GetComponent<Tile_Class>().SetBackgroundHighlight(false);
            Game_Class.instance.primaryTile = this.gameObject;
        }        
        SetBackgroundHighlight(true);
    }
}
