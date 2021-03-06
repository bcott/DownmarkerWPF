﻿using System.Windows.Input;
using ICSharpCode.AvalonEdit;

namespace MarkPad.Document.Events
{
    public class EditorTextEnteringEvent
    {
        public DocumentViewModel ViewModel { get; private set; }
        public TextEditor Editor { get; private set; }
        public TextCompositionEventArgs Args { get; private set; }

        public EditorTextEnteringEvent(DocumentViewModel viewModel, TextEditor editor, TextCompositionEventArgs args)
        {
            ViewModel = viewModel;
            Editor = editor;
            Args = args;
        }
    }
}