using System;
using Community.VisualStudio.Toolkit;
using EnvDTE;
using Microsoft.Internal.VisualStudio.PlatformUI;
using Microsoft.VisualStudio.PlatformUI;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Newtonsoft.Json.Linq;
using stdole;
using Task = System.Threading.Tasks.Task;
using Microsoft.VisualStudio.Shell;
using System.IO;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text;
using System.Reflection.Emit;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;
using System.Linq;

namespace InsertTag
{
    [Command(PackageIds.InsertTagCommentedCmd)]
    internal sealed class InsertTagCommentedCmd : BaseCommand<InsertTagCommentedCmd>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            DocumentView docView = await VS.Documents.GetActiveDocumentViewAsync();
            ITextView textView = docView.TextView;
            ITextCaret caret = textView.Caret;

            // Check if the selection spans multiple lines
            if (textView.Selection.IsEmpty)
            {
                // ignore this sloppy code!!
                int currentLine = caret.Position.BufferPosition.GetContainingLine().LineNumber;
                ITextSnapshotLine line = textView.TextSnapshot.GetLineFromLineNumber(currentLine);
                string lineText = line.GetText();

                using (ITextEdit textEdit = textView.TextBuffer.CreateEdit())
                {
                    textEdit.Apply();
                }

                var position = docView.TextView?.Selection.Start.Position.Position;
                var line2 = docView.TextView.TextSnapshot.GetLineFromPosition(docView.TextView.Caret.Position.BufferPosition);
                var lineStart = line2.Start;
                if (position.HasValue)
                {
                    docView.TextBuffer.Insert(lineStart, Properties.Settings.Default.Tag + "*");
                }
            }
            else
            {
                // Get the selected lines
                var selectedLines = textView.Selection.SelectedSpans.SelectMany(s => textView.TextSnapshot.Lines.Where(line => s.IntersectsWith(line.Extent)));
                using (ITextEdit textEdit = textView.TextBuffer.CreateEdit())
                {
                    // Loop through each selected line
                    foreach (var selectedLine in selectedLines)
                    {
                        textEdit.Insert(selectedLine.Start, Properties.Settings.Default.Tag + "*");
                    }
                    textEdit.Apply();
                }
            }
        }

    }
}

