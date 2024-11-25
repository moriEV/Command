using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class DeleteTextCommand:ICommand
    {
        private readonly TextEditor textEditor;
        private readonly string text;
        public DeleteTextCommand(TextEditor textEditor,string text)
        {
            this.textEditor = textEditor;
            this.text = text;
        }
        public void Execute()
        {
            textEditor.DeleteText(text.Length);
        }
        public void Undo()
        {
            textEditor.InsertText(text);
        }

    }
}
