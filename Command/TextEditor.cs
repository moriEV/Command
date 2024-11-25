using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class TextEditor
    {
        private string _text = String.Empty;
        public void InsertText(string text)
        {
            _text += text;
            Console.WriteLine($"Text added. Total text:{_text}");
        }
        public void DeleteText(int length)
        {
            if (_text.Length > length) 
            {
                _text = _text.Substring(0, _text.Length-length);
                Console.WriteLine($"Deleted {length} characters");
                Console.WriteLine($"Total text:{_text}");
            }
            else
            {
                Console.WriteLine("Cannot delete more characters then exists");
            }
        }
        public string GetText() { return _text; }
    }
}
