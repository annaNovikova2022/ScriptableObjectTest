using UnityEngine;


[CreateAssetMenu(fileName = "item", menuName = "Config/Item")]
public class Item : ScriptableObject
{
    public Sprite SpriteObject
    {
        get => _sprite;
    }
    public string Name
     {
         get => _name;
     }

    [SerializeField] private Sprite _sprite;
    [SerializeField] private string _name;
    
    
}
