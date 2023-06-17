namespace WindowsFormsApp1.Objects
{
    public class Coordinates
    {
        private float x;
        private float y;

        public Coordinates(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float X
        {
            get => x;
            set => x = value;
        }

        public float Y
        {
            get => y;
            set => y = value;
        }
    }
}