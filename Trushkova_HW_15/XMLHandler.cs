namespace Trushkova_HW_15
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open *.xml file.");
        }
        public override void Create()
        {
            Console.WriteLine("Create *.xml file.");
        }
        public override void Change()
        {
            Console.WriteLine("Change *.xml file.");
        }
        public override void Save()
        {
            Console.WriteLine("Save *.xml file.");
        }
    }
}
