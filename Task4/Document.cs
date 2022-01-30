
using Task4;

namespace Classes
{
    class Document : AbstractDocument
    {
        // Поля
        Title title;
        Body body;
        Footer footer;

        public override string Content
        {
            get { return this.title + " " + this.body + " " + this.footer; }
            set { }
        }

        public Document(Title title, Body body, Footer footer)
        {
            this.title = title;
            this.body = body;
            this.footer = footer;
        }

        public override void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }
    }
}
