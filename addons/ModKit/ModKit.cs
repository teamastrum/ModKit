#if TOOLS
using Godot;
using System;

[Tool]
public class ModKit : EditorPlugin
{
    Control dock;
    public override void _EnterTree()
    {
        GD.Print("ModKit initialized!");
        dock = (Control)GD.Load<PackedScene>("addons/ModKit/Docks/ModKit/ModKitProperties.tscn").Instance();
        AddControlToDock(DockSlot.RightBl, dock);
    }

    public override void _ExitTree()
    {
        // Initialization of the plugin goes here
        RemoveControlFromDocks(dock);
        // Erase the control from the memory
        dock.Free();
    }

}
#endif
