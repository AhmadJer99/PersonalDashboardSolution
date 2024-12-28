using System;
using System.Collections.Generic;

namespace PersonalDashboard
{
    public partial class Notes : System.Web.UI.Page
    {
        // Class to represent a note
        public class Note
        {
            public string NoteText { get; set; }
            public DateTime CreatedDate { get; set; }
        }

        // Static list to store notes
        private static List<Note> NotesList = new List<Note>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadNotes();
            }
        }

        // Handle Save Note button click
        protected void btnSaveNote_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNote.Text))
            {
                // Add a new note to the list
                NotesList.Add(new Note
                {
                    NoteText = txtNote.Text,
                    CreatedDate = DateTime.Now
                });

                // Clear the input box
                txtNote.Text = string.Empty;

                // Reload the notes
                LoadNotes();
            }
        }

        // Handle Clear button click
        protected void btnClearNote_Click(object sender, EventArgs e)
        {
            // Clear the input box
            txtNote.Text = string.Empty;
        }

        // Load the notes into the Repeater
        private void LoadNotes()
        {
            rptNotes.DataSource = NotesList;
            rptNotes.DataBind();
        }
    }
}
