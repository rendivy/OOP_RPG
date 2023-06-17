using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1
{
    public class Note: Item
    {
        private NoteForm note = new NoteForm();
        
        public Note(int price, string description): base(price, description, ObjectEnum.NoteAssetId)
        { }

        public override void UseItem()
        {
            GameEngine.IsRunning = false;
            note.ShowDialog();
            GameEngine.IsRunning = true;
        }
    }
}