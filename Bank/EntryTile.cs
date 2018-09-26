using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    class EntryTile
    {
        private DataEntry dataEntry = new DataEntry();
        private TableLayoutPanel mainTable = new TableLayoutPanel();
        private Label entryTextLabel = new Label();
        private Button deleteEntryButton = new Button();
        private Panel panel = new Panel();

        public EntryTile(DataEntry dataEntry_) 
        {
            dataEntry = dataEntry_;
            InitializePanel();
            InitializeMainTable();
            InitializeDeleteEntryButton();
            InitializeEntryTextLabel();
            mainTable.Controls.Add(entryTextLabel, 0, 0);
            mainTable.Controls.Add(deleteEntryButton, 2, 0);
            panel.Controls.Add(mainTable);
        }

        public ref Panel GetPanel()
        {
            return ref panel;
        }

        public ref TableLayoutPanel GetMainTable()
        {
            return ref mainTable;
        }
        public ref Label GetEntryTextLabel()
        {
            return ref entryTextLabel;
        }

        public ref Button GetDeleteEntryButton()
        {
            return ref deleteEntryButton;
        }

        public ref DataEntry GetDataEntry()
        {
            return ref dataEntry;
        }

        private void InitializePanel()
        {
            Padding padding = new Padding(0, 0, 50, 0);
            panel.Padding = padding;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
        }

        private void InitializeMainTable()
        {
            mainTable.RowCount = 3;
            mainTable.ColumnCount = 2;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent) { Width = 90 });
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent) { Width = 10 });
            mainTable.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            mainTable.MouseEnter += (sender, e) =>
            {
                MouseEnter();
            };
            mainTable.MouseLeave += (sender, e) =>
            {
                MouseLeave();
            };
           
        }

        private void InitializeEntryTextLabel()
        {
            entryTextLabel.Height = mainTable.Height - 5;
            entryTextLabel.Text = dataEntry.Id + "| " + "$" + String.Format(dataEntry.Value % 1 == 0 ? "{0:F0}" : "{0:F2}", dataEntry.Value) + "\r\n" + dataEntry.Date + "\r\n" + dataEntry.Description + "\r\n" + dataEntry.TagsToString(dataEntry.Tags);
            entryTextLabel.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);

            entryTextLabel.MouseEnter += (sender, e) => { MouseEnter(); };
            entryTextLabel.MouseLeave += (sender, e) => { MouseLeave(); };
        }

        private void InitializeDeleteEntryButton()
        {
            deleteEntryButton.Image = Properties.Resources.Exit_Up;
            deleteEntryButton.FlatStyle = FlatStyle.Flat;
            deleteEntryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            deleteEntryButton.FlatAppearance.BorderSize = 0;
            deleteEntryButton.Width = 20;
            deleteEntryButton.Height = 20;
            deleteEntryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            deleteEntryButton.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
            deleteEntryButton.Hide();

            deleteEntryButton.MouseEnter += (sender, e) =>
            {
                deleteEntryButton.Image = Properties.Resources.Exit_Hover;
            };

            deleteEntryButton.MouseLeave += (sender, e) =>
            {
                deleteEntryButton.Image = Properties.Resources.Exit_Up;
            };

            deleteEntryButton.MouseDown += (sender, e) =>
            {
                deleteEntryButton.Image = Properties.Resources.Exit_Down;
            };

            deleteEntryButton.MouseUp += (sender, e) =>
            {
                deleteEntryButton.Image = Properties.Resources.Exit_Hover;
            };

            deleteEntryButton.Click += (sender, e) =>
            {

            };
        }

        private void MouseEnter()
        {
            mainTable.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            deleteEntryButton.Show();
        }

        private void MouseLeave()
        {
            System.Drawing.Point mouseLocation = mainTable.PointToClient(Cursor.Position);
            int left = deleteEntryButton.Left;
            int right = deleteEntryButton.Right;
            int top = deleteEntryButton.Top;
            int bottom = deleteEntryButton.Bottom;
            if (!(mouseLocation.X > left && mouseLocation.X < right && mouseLocation.Y > top && mouseLocation.Y < bottom))
            {
                mainTable.BackColor = System.Drawing.Color.FromArgb(0);
                deleteEntryButton.Hide();
            }
        }
    }
}
