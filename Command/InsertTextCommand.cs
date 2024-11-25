using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class InsertTextCommand : ICommand
    {
        private readonly TextEditor textEditor;
        private readonly string text;
        public InsertTextCommand(TextEditor textEditor, string text)
        {
            this.textEditor = textEditor;
            this.text = text;
        }
        public void Execute() 
        {
            textEditor.InsertText(text);
        }
        public void Undo() 
        {
            textEditor.DeleteText(text.Length);
        }

    }
}
