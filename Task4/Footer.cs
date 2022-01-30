using Task4;

namespace Classes
{
    class Footer : AbstractDocument
    {
        private string? _content;

        public override string Content
        {
            get
            {
                if (_content != null)
                    return _content;
                else
                    return "Нижний колонтитул отсутствует.";
            }
            set
            {
                _content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
