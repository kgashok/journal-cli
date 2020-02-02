using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace JournalCli.Core
{
    internal class JournalEntryBody : IEnumerable<JournalEntryBodyElement>
    {
        // How to handle entries without a header?
        // How to ensure all text remain in original order?

        //private readonly Dictionary<string, string> _body = new Dictionary<string, string>();
        //private readonly List<KeyValuePair>
        private readonly Tuple<string, string> _body;

        public JournalEntryBody(string[] rawBodyText)
        {
            var t = Tuple.Create<string, string>("", "");
        }

        public IEnumerator<JournalEntryBodyElement> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void Parse(string[] rawBodyText)
        {
            foreach (var line in rawBodyText)
            {

            }
        }
    }

    internal class JournalEntryBodyElement
    {
        public JournalEntryBodyElementType Type { get; }

        public string Text { get; }
    }

    internal enum JournalEntryBodyElementType
    {
        Header,
        Paragraph
    }
}
