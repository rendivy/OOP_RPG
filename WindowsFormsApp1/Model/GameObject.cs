using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects
{
    public abstract class GameObject
    {
        public ObjectType Type;
        public Coordinates Coordinates;
        public ObjectEnum ID;
        
        protected Inventory inventory;
        
        public Inventory Inventory => inventory;
    }
}