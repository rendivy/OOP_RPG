using WindowsFormsApp1.Objects.Assets;
using WindowsFormsApp1.Objects.Dungeon;

namespace WindowsFormsApp1.Objects
{
    public static class Interaction
    {
        private static NPCinteraction.Interact _npcInteraction = NPCinteract;
        private static NPCinteraction.Interact chestInteract = ChestInteract;
        
        private static void NPCinteract(GameObject obj)
        {
            GameEngine.MainCharacter.GetItems(obj.Inventory.Items);
        }
        
        private static void ChestInteract(GameObject obj)
        {
            GameEngine.MainCharacter.Inventory.AddItem(((Chest)obj).OpenChest("kluch"));
        }
        
        public static NPCinteraction.Interact NpcInteraction => _npcInteraction;
        public static NPCinteraction.Interact ChestInteraction => chestInteract;
    }
}