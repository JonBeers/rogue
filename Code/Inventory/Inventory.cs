using Sandbox;

public sealed class Inventory : Component
{
	[Sync] public NetList<string> ItemIds { get; set; } = new ();

	public bool AddItem(string itemId)
	{
		var item = ItemDatabase.Items.FirstOrDefault(i => i.Id == itemId);
		if (item == null) return false;

		ItemIds.Add(itemId);
		return true;
	}

	public bool RemoveItem(string itemId)
	{
		return ItemIds.Remove(itemId);
	}

	public List<Item> GetItems()
	{
		return ItemIds.Select(id => ItemDatabase.Items.FirstOrDefault(i => i.Id == id)).Where(i => i != null).ToList();
	}

	public Item GetItem(string itemId)
    {
        if (!ItemIds.Contains(itemId)) return null;
        return ItemDatabase.Items.FirstOrDefault(i => i.Id == itemId);
    }


    protected override void OnStart()
    {
		AddItem("weapon_knife");
		AddItem("phone");
    }

}
