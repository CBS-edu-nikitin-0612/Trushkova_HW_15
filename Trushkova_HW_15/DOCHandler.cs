namespace Trushkova_HW_15
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open *.doc file.");
        }
        public override void Create()
        {
            Console.WriteLine("Create *.doc file.");
        }
        public override void Change()
        {
            Console.WriteLine("Change *.doc file.");
        }
        public override void Save()
        {
            Console.WriteLine("Save *.doc file.");
        }
    }
}
