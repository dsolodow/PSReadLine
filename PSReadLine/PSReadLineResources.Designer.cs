﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSConsoleUtilities {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PSReadLineResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PSReadLineResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PSReadLine.PSReadLineResources", typeof(PSReadLineResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Abort the current operation, e.g. incremental history search.
        /// </summary>
        internal static string AbortDescription {
            get {
                return ResourceManager.GetString("AbortDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accept the current line and recall the next line from history after the current line finishes executing.
        /// </summary>
        internal static string AcceptAndGetNextDescription {
            get {
                return ResourceManager.GetString("AcceptAndGetNextDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accept the input or move to the next line if input is missing a closing token..
        /// </summary>
        internal static string AcceptLineDescription {
            get {
                return ResourceManager.GetString("AcceptLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the next line without attempting to execute the input.
        /// </summary>
        internal static string AddLineDescription {
            get {
                return ResourceManager.GetString("AddLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor back one character.
        /// </summary>
        internal static string BackwardCharDescription {
            get {
                return ResourceManager.GetString("BackwardCharDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete the charcter before the cursor.
        /// </summary>
        internal static string BackwardDeleteCharDescription {
            get {
                return ResourceManager.GetString("BackwardDeleteCharDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete text from the cursor to the start of the line.
        /// </summary>
        internal static string BackwardDeleteLineDescription {
            get {
                return ResourceManager.GetString("BackwardDeleteLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the text from the cursor to the beginning of the line to the kill ring.
        /// </summary>
        internal static string BackwardKillLineDescription {
            get {
                return ResourceManager.GetString("BackwardKillLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the text from the start of the current or previous word to the cursor to the kill ring.
        /// </summary>
        internal static string BackwardKillWordDescription {
            get {
                return ResourceManager.GetString("BackwardKillWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the beginning of the current or previous word.
        /// </summary>
        internal static string BackwardWordDescription {
            get {
                return ResourceManager.GetString("BackwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move to the first item in the history.
        /// </summary>
        internal static string BeginningOfHistoryDescription {
            get {
                return ResourceManager.GetString("BeginningOfHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the beginning of the line.
        /// </summary>
        internal static string BeginningOfLineDescription {
            get {
                return ResourceManager.GetString("BeginningOfLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Abort editing the current line and re-evaluate the prompt.
        /// </summary>
        internal static string CancelLineDescription {
            get {
                return ResourceManager.GetString("CancelLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allows you to select multiple lines from the console using Shift+UpArrow/DownArrow and copy the selected lines to clipboard by pressing Enter..
        /// </summary>
        internal static string CaptureScreenDescription {
            get {
                return ResourceManager.GetString("CaptureScreenDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Read a character and move the cursor to the previous occurence of that character.
        /// </summary>
        internal static string CharacterSearchBackwardDescription {
            get {
                return ResourceManager.GetString("CharacterSearchBackwardDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Read a character and move the cursor to the next occurence of that character.
        /// </summary>
        internal static string CharacterSearchDescription {
            get {
                return ResourceManager.GetString("CharacterSearchDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all items from the command line history (not PowerShell history).
        /// </summary>
        internal static string ClearHistoryDescription {
            get {
                return ResourceManager.GetString("ClearHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all items from the kill ring.
        /// </summary>
        internal static string ClearKillRingDescription {
            get {
                return ResourceManager.GetString("ClearKillRingDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clear the screen and redraw the current line at the top of the screen.
        /// </summary>
        internal static string ClearScreenDescription {
            get {
                return ResourceManager.GetString("ClearScreenDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command &apos;{0}&apos; cannot be found..
        /// </summary>
        internal static string CommandNotFoundError {
            get {
                return ResourceManager.GetString("CommandNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Complete the input if there is a single completion, otherwise complete the input with common prefix for all completions.  Show possible completions if pressed a second time..
        /// </summary>
        internal static string CompleteDescription {
            get {
                return ResourceManager.GetString("CompleteDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy selected region to the system clipboard.  If no region is selected, copy the whole line.
        /// </summary>
        internal static string CopyDescription {
            get {
                return ResourceManager.GetString("CopyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Either copy selected text to the clipboard, or if no text is selected, cancel editing the line with CancelLine..
        /// </summary>
        internal static string CopyOrCancelLineDescription {
            get {
                return ResourceManager.GetString("CopyOrCancelLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete selected region placing deleted text in the system clipboard.
        /// </summary>
        internal static string CutDescription {
            get {
                return ResourceManager.GetString("CutDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete the character under the cusor.
        /// </summary>
        internal static string DeleteCharDescription {
            get {
                return ResourceManager.GetString("DeleteCharDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete the character under the cusor, or if the line is empty, exit the process..
        /// </summary>
        internal static string DeleteCharOrExitDescription {
            get {
                return ResourceManager.GetString("DeleteCharOrExitDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start or accumulate a numeric argument to other functions.
        /// </summary>
        internal static string DigitArgumentDescription {
            get {
                return ResourceManager.GetString("DigitArgumentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display all {0} possibilities? (y or n) _.
        /// </summary>
        internal static string DisplayAllPossibilities {
            get {
                return ResourceManager.GetString("DisplayAllPossibilities", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String is not used in the UI.
        /// </summary>
        internal static string EmacsCtrlXDescription {
            get {
                return ResourceManager.GetString("EmacsCtrlXDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String is not used in the UI.
        /// </summary>
        internal static string EmacsMetaDescription {
            get {
                return ResourceManager.GetString("EmacsMetaDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move to the last item (the current input) in the history.
        /// </summary>
        internal static string EndOfHistoryDescription {
            get {
                return ResourceManager.GetString("EndOfHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the end of the line.
        /// </summary>
        internal static string EndOfLineDescription {
            get {
                return ResourceManager.GetString("EndOfLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mark the location of the cursor and move the cursor to the position of the previous mark.
        /// </summary>
        internal static string ExchangePointAndMarkDescription {
            get {
                return ResourceManager.GetString("ExchangePointAndMarkDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor forward one character.
        /// </summary>
        internal static string ForwardCharDescription {
            get {
                return ResourceManager.GetString("ForwardCharDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete text from the cursor to the end of the line.
        /// </summary>
        internal static string ForwardDeleteLineDescription {
            get {
                return ResourceManager.GetString("ForwardDeleteLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search history forward interactively.
        /// </summary>
        internal static string ForwardSearchHistoryDescription {
            get {
                return ResourceManager.GetString("ForwardSearchHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor forward to the end of the current word, or if between words, to the end of the next word. .
        /// </summary>
        internal static string ForwardWordDescription {
            get {
                return ResourceManager.GetString("ForwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Go to matching brace.
        /// </summary>
        internal static string GotoBraceDescription {
            get {
                return ResourceManager.GetString("GotoBraceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search for the previous item in the history that starts with the current input - like PreviousHistory if the input is empty.
        /// </summary>
        internal static string HistorySearchBackwardDescription {
            get {
                return ResourceManager.GetString("HistorySearchBackwardDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search for the next item in the history that starts with the current input - like NextHistory if the input is empty.
        /// </summary>
        internal static string HistorySearchForwardDescription {
            get {
                return ResourceManager.GetString("HistorySearchForwardDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String is not used in the UI.
        /// </summary>
        internal static string IgnoreDescription {
            get {
                return ResourceManager.GetString("IgnoreDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erases the current prompt and calls the prompt function to redisplay the prompt.
        /// </summary>
        internal static string InvokePromptDescription {
            get {
                return ResourceManager.GetString("InvokePromptDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key is unbound.
        /// </summary>
        internal static string KeyIsUnbound {
            get {
                return ResourceManager.GetString("KeyIsUnbound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the text from the cursor to the end of the input to the kill ring.
        /// </summary>
        internal static string KillLineDescription {
            get {
                return ResourceManager.GetString("KillLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kill the text between the cursor and the mark.
        /// </summary>
        internal static string KillRegionDescription {
            get {
                return ResourceManager.GetString("KillRegionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the text from the cursor to the end of the current or next word to the kill ring.
        /// </summary>
        internal static string KillWordDescription {
            get {
                return ResourceManager.GetString("KillWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Complete the input if there is a single completion, otherwise complete the input by selecting from a menu of possible completions..
        /// </summary>
        internal static string MenuCompleteDescription {
            get {
                return ResourceManager.GetString("MenuCompleteDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace the input with the next item in the history.
        /// </summary>
        internal static string NextHistoryDescription {
            get {
                return ResourceManager.GetString("NextHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the next line if the input has multiple lines..
        /// </summary>
        internal static string NextLineDescription {
            get {
                return ResourceManager.GetString("NextLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor forward to the start of the next word.
        /// </summary>
        internal static string NextWordDescription {
            get {
                return ResourceManager.GetString("NextWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Oops, something went wrong.  Please report this bug with the details below.
        ///Report on GitHub: https://github.com/lzybkr/PSReadLine/issues/new
        ///Or email: jason@truewheels.net.
        /// </summary>
        internal static string OopsAnErrorMessage1 {
            get {
                return ResourceManager.GetString("OopsAnErrorMessage1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -----------------------------------------------------------------------
        ///Last {0} Keys:
        ///{1}
        ///
        ///Exception:
        ///{2}
        ///-----------------------------------------------------------------------.
        /// </summary>
        internal static string OopsAnErrorMessage2 {
            get {
                return ResourceManager.GetString("OopsAnErrorMessage2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Paste text from the system clipboard.
        /// </summary>
        internal static string PasteDescription {
            get {
                return ResourceManager.GetString("PasteDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display the possible completions without changing the input.
        /// </summary>
        internal static string PossibleCompletionsDescription {
            get {
                return ResourceManager.GetString("PossibleCompletionsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace the input with the previous item in the history.
        /// </summary>
        internal static string PreviousHistoryDescription {
            get {
                return ResourceManager.GetString("PreviousHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the previous line if the input has multiple lines..
        /// </summary>
        internal static string PreviousLineDescription {
            get {
                return ResourceManager.GetString("PreviousLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Redo an undo.
        /// </summary>
        internal static string RedoDescription {
            get {
                return ResourceManager.GetString("RedoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to length is too big.
        /// </summary>
        internal static string ReplacementLengthTooBig {
            get {
                return ResourceManager.GetString("ReplacementLengthTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search history backwards interactively.
        /// </summary>
        internal static string ReverseSearchHistoryDescription {
            get {
                return ResourceManager.GetString("ReverseSearchHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Equivalent to undo all edits (clears the line except lines imported from history).
        /// </summary>
        internal static string RevertLineDescription {
            get {
                return ResourceManager.GetString("RevertLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scroll the display down one screen.
        /// </summary>
        internal static string ScrollDisplayDownDescription {
            get {
                return ResourceManager.GetString("ScrollDisplayDownDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scroll the display down one line.
        /// </summary>
        internal static string ScrollDisplayDownLineDescription {
            get {
                return ResourceManager.GetString("ScrollDisplayDownLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scroll the display to the cursor.
        /// </summary>
        internal static string ScrollDisplayToCursorDescription {
            get {
                return ResourceManager.GetString("ScrollDisplayToCursorDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scroll the display to the top.
        /// </summary>
        internal static string ScrollDisplayTopDescription {
            get {
                return ResourceManager.GetString("ScrollDisplayTopDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scroll the display up one screen.
        /// </summary>
        internal static string ScrollDisplayUpDescription {
            get {
                return ResourceManager.GetString("ScrollDisplayUpDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scroll the display up one line.
        /// </summary>
        internal static string ScrollDisplayUpLineDescription {
            get {
                return ResourceManager.GetString("ScrollDisplayUpLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the entire line. Moves the cursor to the end of the line.
        /// </summary>
        internal static string SelectAllDescription {
            get {
                return ResourceManager.GetString("SelectAllDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjust the current selection to include the previous character.
        /// </summary>
        internal static string SelectBackwardCharDescription {
            get {
                return ResourceManager.GetString("SelectBackwardCharDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjust the current selection to include from the cursor to the end of the line.
        /// </summary>
        internal static string SelectBackwardsLineDescription {
            get {
                return ResourceManager.GetString("SelectBackwardsLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjust the current selection to include the previous word.
        /// </summary>
        internal static string SelectBackwardWordDescription {
            get {
                return ResourceManager.GetString("SelectBackwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjust the current selection to include the next character.
        /// </summary>
        internal static string SelectForwardCharDescription {
            get {
                return ResourceManager.GetString("SelectForwardCharDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjust the current selection to include the next word using ForwardWord.
        /// </summary>
        internal static string SelectForwardWordDescription {
            get {
                return ResourceManager.GetString("SelectForwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjust the current selection to include from the cursor to the start of the line.
        /// </summary>
        internal static string SelectLineDescription {
            get {
                return ResourceManager.GetString("SelectLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjust the current selection to include the next word.
        /// </summary>
        internal static string SelectNextWordDescription {
            get {
                return ResourceManager.GetString("SelectNextWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjust the current selection to include the previous word using ShellBackwardWord.
        /// </summary>
        internal static string SelectShellBackwardWordDescription {
            get {
                return ResourceManager.GetString("SelectShellBackwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjust the current selection to include the next word using ShellForwardWord.
        /// </summary>
        internal static string SelectShellForwardWordDescription {
            get {
                return ResourceManager.GetString("SelectShellForwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjust the current selection to include the next word using ShellNextWord.
        /// </summary>
        internal static string SelectShellNextWordDescription {
            get {
                return ResourceManager.GetString("SelectShellNextWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Insert the key typed.
        /// </summary>
        internal static string SelfInsertDescription {
            get {
                return ResourceManager.GetString("SelfInsertDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mark the location of the cursor.
        /// </summary>
        internal static string SetMarkDescription {
            get {
                return ResourceManager.GetString("SetMarkDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the text from the cursor to the start of the current or previous token to the kill ring.
        /// </summary>
        internal static string ShellBackwardKillWordDescription {
            get {
                return ResourceManager.GetString("ShellBackwardKillWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the beginning of the current or previous token or start of the line.
        /// </summary>
        internal static string ShellBackwardWordDescription {
            get {
                return ResourceManager.GetString("ShellBackwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the beginning of the next token or end of line.
        /// </summary>
        internal static string ShellForwardWordDescription {
            get {
                return ResourceManager.GetString("ShellForwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the text from the cursor to the end of the current or next token to the kill ring.
        /// </summary>
        internal static string ShellKillWordDescription {
            get {
                return ResourceManager.GetString("ShellKillWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the end of the current token.
        /// </summary>
        internal static string ShellNextWordDescription {
            get {
                return ResourceManager.GetString("ShellNextWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show all key bindings.
        /// </summary>
        internal static string ShowKeyBindingsDescription {
            get {
                return ResourceManager.GetString("ShowKeyBindingsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;start&apos; cannot be less than zero or greater than the length of the buffer.
        /// </summary>
        internal static string StartOutOfRange {
            get {
                return ResourceManager.GetString("StartOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Complete the input using the next completion.
        /// </summary>
        internal static string TabCompleteNextDescription {
            get {
                return ResourceManager.GetString("TabCompleteNextDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Complete the input using the previous completion.
        /// </summary>
        internal static string TabCompletePreviousDescription {
            get {
                return ResourceManager.GetString("TabCompletePreviousDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Undo a previous edit.
        /// </summary>
        internal static string UndoDescription {
            get {
                return ResourceManager.GetString("UndoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the text from the cursor to the start of the current or previous whitespace delimited word to the kill ring.
        /// </summary>
        internal static string UnixWordRuboutDescription {
            get {
                return ResourceManager.GetString("UnixWordRuboutDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accept the input or move to the next line if input is missing a closing token.
        ///If there are other parse errors, unresolved commands, or incorrect parameters, show the error and continue editing..
        /// </summary>
        internal static string ValidateAndAcceptLineDescription {
            get {
                return ResourceManager.GetString("ValidateAndAcceptLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show the key binding for the next chord entered.
        /// </summary>
        internal static string WhatIsKeyDescription {
            get {
                return ResourceManager.GetString("WhatIsKeyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy the text from the current kill ring position to the input.
        /// </summary>
        internal static string YankDescription {
            get {
                return ResourceManager.GetString("YankDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy the text of the last argument to the input.
        /// </summary>
        internal static string YankLastArgDescription {
            get {
                return ResourceManager.GetString("YankLastArgDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy the text of the first argument to the input.
        /// </summary>
        internal static string YankNthArgDescription {
            get {
                return ResourceManager.GetString("YankNthArgDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace the previously yanked text with the text from the next kill ring position.
        /// </summary>
        internal static string YankPopDescription {
            get {
                return ResourceManager.GetString("YankPopDescription", resourceCulture);
            }
        }
    }
}
