namespace Trushkova_HW_15
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open *.txt file.");
        }
        public override void Create()
        {
            Console.WriteLine("Create *.txt file.");
        }
        public override void Change()
        {
            Console.WriteLine("Change *.txt file.");
        }
        public override void Save()
        {
            Console.WriteLine("Save *.txt file.");
        }
    }
}
