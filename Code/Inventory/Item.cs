using System;
namespace Sandbox;
public class Item
{
    public string Id {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}
    public string ModelPath {get; set;} 
    public string ImagePath {get; set;}
    public ItemType Type {get; set;}
    public float Weight {get; set;}

    public enum ItemType 
    {
        Weapon,
        Armor,
        Consumable,
        Misc
    }

    public static void SpawnItem(Item item, Vector3 position)
    {
        if (item == null) return;

        var _item = new GameObject();
        var renderer = _item.AddComponent<ModelRenderer>();

        // Set the model for the item
        renderer.Model = Model.Load(item.ModelPath);

        // Set the position of the item in the world
        _item.WorldPosition = position;
    }
}

public static class ItemDatabase
{
    public static List<Item> Items = new List<Item>
    {
        new Item {
            Id = "weapon_knife",
            Name = "Knife",
            Description = "A combat knife used for gutting animals.",
            ModelPath = "models/sword.vmdl_c",
            ImagePath = "images/inventory/weapon_knife.png",
            Type = Item.ItemType.Weapon,
            Weight = 1f
        },
        new Item {
            Id = "phone",
            Name = "Mobile Phone",
            Description = "Used for communication.",
            ModelPath = "models/sword.vmdl_c",
            ImagePath = "images/inventory/purple_phone.png",
            Type = Item.ItemType.Misc,
            Weight = .8f
        },
    };
}