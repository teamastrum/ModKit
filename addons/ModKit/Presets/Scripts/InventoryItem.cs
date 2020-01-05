using Godot;
using System;

public class InventoryItem : Node
{
    [Export]
    public string ItemName = "My Item";
    [Export(PropertyHint.MultilineText, "Description of the item. BBCode is supported.")]
    public string ItemDescription = "My cool item, which I made using [b]ModKit[/b]";
    [Export]
    public string ItemID = "myname_mymod_myitem";
    [Export]
    public bool IsWeapon = false;
    [Export]
    public PackedScene WeaponClass;
    [Export]
    public string ViewmodelName = "None";
    [Export]
    public StreamTexture ItemIcon;


    public void ItemSelected()
    {

    }
    public void ItemUsed()
    {

    }
}