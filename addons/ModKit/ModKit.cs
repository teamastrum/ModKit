#if TOOLS
using Godot;
using System;

[Tool]
public class ModKit : EditorPlugin
{
    Control PropertiesDock;
    Control ToolsDock;

    public override void _EnterTree()
    {
        GD.Print("ModKit initialized!");

        // Initialize the ModSettings dock first, for UX reasons

        PropertiesDock = (Control)GD.Load<PackedScene>("addons/ModKit/Docks/ModKit/ModKitProperties.tscn").Instance();
        AddControlToDock(DockSlot.RightBl, PropertiesDock);

        ToolsDock = (Control)GD.Load<PackedScene>("res://addons/ModKit/Docks/ModKit/ModKitTools.tscn").Instance();
        AddControlToDock(DockSlot.RightBl, ToolsDock);
    }

    public override void _ExitTree()
    {
        // Initialization of the plugin goes here
        RemoveControlFromDocks(PropertiesDock);
        RemoveControlFromDocks(ToolsDock);
        // Erase the control from the memory
        PropertiesDock.Free();
        ToolsDock.Free();
    }

    public static void InitializeMod(string Type)
    {
        if(Type == "Item")
        {
            GD.Print("Initializing Item mod");
        }
    }

}
#endif
