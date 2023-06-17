using System;
using System.Collections.Generic;
using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects
{
    public static class NPCinteraction
    {
        public delegate void Interact(GameObject obj);
        
        private static Dictionary<Enum, Interact> interacts =
                new Dictionary<Enum, Interact>()
                {
                    {ObjectEnum.FirekeeperAssetId, Interaction.NpcInteraction},
                    {ObjectEnum.VendorAssetId, Interaction.NpcInteraction},
                    {ObjectEnum.BlacksmithAssetId, Interaction.NpcInteraction},
                    {ObjectEnum.ChestAssetId, Interaction.ChestInteraction}
                };

        public static Interact GetInteraction(ObjectEnum id)
        {
            return interacts[id];
        }
    }
}