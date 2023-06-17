using System.Collections.Generic;

namespace WindowsFormsApp1.Objects
{
    public class NPCfactory
    {
        private List<NPC> NpcList = new List<NPC>();
        
        public NPCfactory(float width, float height)
        {
            NpcList.Add(new Vendor(GameEngine.GetRandomCoordinates(width, height)));
            NpcList.Add(new Blacksmith(GameEngine.GetRandomCoordinates(width, height)));
            NpcList.Add(new Firekeeper(GameEngine.GetRandomCoordinates(width, height)));
        }
        
        public List<NPC> NPClist
        {
            get
            {
                return NpcList;
            }
        }
    }
}